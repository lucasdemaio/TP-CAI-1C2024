using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;
using System.IO;

namespace Negocio
{
    public class ReporteNegocio
    {
        private string pathDB;
        private UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        private ProductoNegocio productoNegocio = new ProductoNegocio();

        private readonly Dictionary<int, string> categorias = new Dictionary<int, string>
        {
            { 1, "Audio" },
            { 2, "Celulares" },
            { 3, "Electro Hogar" },
            { 4, "Informatica" },
            { 5, "Smart TV" }
        };

        public ReporteNegocio(string pathDB, UsuarioNegocio usuarioNegocio, ProductoNegocio productoNegocio)
        {
            this.pathDB = pathDB;
            this.usuarioNegocio = usuarioNegocio;
            this.productoNegocio = productoNegocio;
        }

        private List<VentaAlta> LeerVentasDesdeJson()
        {
            if (File.Exists(pathDB))
            {
                var json = File.ReadAllText(pathDB);
                return JsonConvert.DeserializeObject<List<VentaAlta>>(json) ?? new List<VentaAlta>();
            }
            return new List<VentaAlta>();
        }

        public List<dynamic> GenerarReporteVentasPorVendedor()
        {
            List<VentaAlta> ventas = LeerVentasDesdeJson();
            List<Usuario> usuarios = usuarioNegocio.listarUsuarios();

            var informe = ventas
                .GroupBy(v => new { v.IdUsuario, Mes = v.FechaVenta.ToString("yyyy-MM") })
                .Select(g => new
                {
                    IdUsuario = g.Key.IdUsuario,
                    Mes = g.Key.Mes,
                    CantidadVentas = g.Count(),
                    MontoTotal = g.Sum(v => v.MontoTotal)
                })
                .Join(usuarios,
                      venta => venta.IdUsuario,
                      usuario => usuario.id.ToString(),
                      (venta, usuario) => new
                      {
                          Vendedor = $"{usuario.Nombre} {usuario.Apellido}",
                          Mes = venta.Mes,
                          CantidadVentas = venta.CantidadVentas,
                          MontoTotal = venta.MontoTotal
                      })
                .OrderBy(i => i.Vendedor)
                .ThenBy(i => i.Mes)
                .ToList<dynamic>();

            return informe;
        }

        public List<dynamic> GenerarReporteProductosMasVendidos()
        {
            List<VentaAlta> ventas = LeerVentasDesdeJson();
            List<ProductoDatos> productos = productoNegocio.listarProductos();

            var informe = ventas
                .GroupBy(v => v.IdProducto)
                .Select(g => new
                {
                    IdProducto = g.Key,
                    CantidadVentas = g.Sum(v => v.Cantidad)
                })
                .Join(productos,
                      venta => venta.IdProducto,
                      producto => producto.Id.ToString(),
                      (venta, producto) => new
                      {
                          Producto = producto.Nombre,
                          Categoria = categorias.ContainsKey(producto.IdCategoria) ? categorias[producto.IdCategoria] : "Desconocida",
                          CantidadVentas = venta.CantidadVentas
                      })
                .OrderByDescending(i => i.CantidadVentas)
                .ThenBy(i => i.Producto)
                .ToList<dynamic>();

            return informe;
        }

        public List<dynamic> GenerarReporteProductosConStockCritico()
        {
            List<ProductoDatos> productosCriticos = productoNegocio.ObtenerProductosConStockCritico();

            var informe = productosCriticos
                .GroupBy(p => p.IdCategoria)
                .SelectMany(g => g.Select(p => new
                {
                    Producto = p.Nombre,
                    Categoria = categorias.ContainsKey(p.IdCategoria) ? categorias[p.IdCategoria] : "Desconocida",
                    Stock = p.Stock
                }))
                .OrderBy(p => p.Categoria)
                .ThenBy(p => p.Producto)
                .ToList<dynamic>();

            return informe;
        }
    }
}

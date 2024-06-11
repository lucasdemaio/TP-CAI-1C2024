using Datos;
using Newtonsoft.Json;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Negocio
{
    public class ProductoNegocio
    {
        private ProductoService productoService = new ProductoService();
        private string pathDB = @"C:\ElectroHogarDB\productos.json";

        public void agregarProducto(string idUsuario, int idCategoria, string idProveedor, string nombreProveedor, string apellidoProveedor, string nombre, double precio, int stock)
        {
            ProductoAlta altaProducto = new ProductoAlta(idCategoria, idUsuario, idProveedor, nombre, precio, stock);
            try
            {
                productoService.AgregarProducto(altaProducto);

                ProductoDatos nuevoProducto = new ProductoDatos
                {
                    Nombre = nombre,
                    Precio = precio,
                    Stock = stock,
                    IdCategoria = idCategoria,
                    IdProveedor = Guid.Parse(idProveedor),
                    NombreProveedor = nombreProveedor,
                    ApellidoProveedor = apellidoProveedor
                };

                GuardarProductoLocal(nuevoProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el producto", ex);
            }
        }

        private void GuardarProductoLocal(ProductoDatos producto)
        {
            string path = @"C:\ElectroHogarDB\productos.json";
            List<ProductoDatos> productos = new List<ProductoDatos>();

            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                productos = JsonConvert.DeserializeObject<List<ProductoDatos>>(json) ?? new List<ProductoDatos>();
            }

            productos.Add(producto);

            var serializedData = JsonConvert.SerializeObject(productos, Formatting.Indented);
            File.WriteAllText(path, serializedData);
        }

        public void eliminarProducto(string idProducto, string idUsuario, string nombreProducto)
        {
            ProductoBaja bajaProducto = new ProductoBaja(idProducto, idUsuario);
            try
            {
                productoService.BorrarProducto(bajaProducto);
                ActualizarFechaBajaProductoEnJson(nombreProducto, idProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto", ex);
            }
        }

        private void ActualizarFechaBajaProductoEnJson(string nombreProducto, string idProducto)
        {
            string path = @"C:\ElectroHogarDB\productos.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var productos = JsonConvert.DeserializeObject<List<ProductoDatos>>(json) ?? new List<ProductoDatos>();

                var producto = productos.FirstOrDefault(p => p.Nombre.ToString() == nombreProducto);
                if (producto != null)
                {
                    producto.FechaBaja = DateTime.Now;
                    producto.Id = Guid.Parse(idProducto);

                    var serializedData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                    File.WriteAllText(path, serializedData);
                }
            }
        }

        public List<ProductoDatos> listarProductos()
        {
            return productoService.getProductos();
        }

        public void modificarProducto(string idProducto, string idUsuario, double precio, int stock)
        {
            ProductoModificacion producto = new ProductoModificacion(idProducto, idUsuario, precio, stock);
            try
            {
                productoService.ModificarProducto(producto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el producto", ex);
            }
        }

        public void reactivarProducto(string idProducto, string idUsuario, string nombreProducto)
        {
            ProductoReactivar producto = new ProductoReactivar(idProducto, idUsuario);
            try
            {
                productoService.ReactivarProducto(producto);
                ReactivarProductoEnJson(nombreProducto, idProducto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al reactivar el producto", ex);
            }
        }

        private void ReactivarProductoEnJson(string nombreProducto, string idProducto)
        {
            string path = @"C:\ElectroHogarDB\productos.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var productos = JsonConvert.DeserializeObject<List<ProductoDatos>>(json) ?? new List<ProductoDatos>();

                var producto = productos.FirstOrDefault(p => p.Nombre.ToString() == nombreProducto);
                if (producto != null)
                {
                    producto.FechaBaja = null;
                    producto.Id = Guid.Parse(idProducto);

                    var serializedData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                    File.WriteAllText(path, serializedData);
                }
            }
        }

        public int ContarProductosConStockCritico()
        {
            const int UmbralStockCritico = 5;
            List<ProductoDatos> todosLosProductos = listarProductos();
            return todosLosProductos.Count(p => p.Stock <= UmbralStockCritico);
        }

        public List<ProductoDatos> ObtenerProductosConStockCritico()
        {
            const int UmbralStockCritico = 5;
            List<ProductoDatos> productos = listarProductos();
            return productos.Where(p => p.Stock <= UmbralStockCritico).ToList();
        }

        public List<ProductoDatos> LeerProductosDadosDeBaja()
        {
            if (File.Exists(pathDB))
            {
                var json = File.ReadAllText(pathDB);
                var productos = JsonConvert.DeserializeObject<List<ProductoDatos>>(json);
                return productos
                    .Where(p => p.FechaBaja != null)
                    .OrderBy(p => p.ApellidoProveedor)
                    .Select(p => new ProductoDatos
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        Stock = p.Stock,
                        FechaBaja = p.FechaBaja
                    }).ToList();
            }
            else
            {
                throw new FileNotFoundException("El archivo de productos no fue encontrado.");
            }
        }
        public List<ProductoDatos> GetProductosPorCategoria(int categoria)
        {
            try
            {
                return productoService.GetProductosporCategoria(categoria);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos por categoría: " + ex.Message);
                return new List<ProductoDatos>();
            }
        }
        public void ActualizarProductoEnJson(string nombreProducto, double nuevoPrecio, int nuevoStock)
        {
            string path = @"C:\ElectroHogarDB\productos.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var productos = JsonConvert.DeserializeObject<List<ProductoDatos>>(json) ?? new List<ProductoDatos>();

                var producto = productos.FirstOrDefault(p => p.Nombre.Equals(nombreProducto, StringComparison.OrdinalIgnoreCase));
                if (producto != null)
                {
                    producto.Precio = nuevoPrecio;
                    producto.Stock += nuevoStock;

                    var serializedData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                    File.WriteAllText(path, serializedData);
                }
            }
        }
   
        public void InicializarProductosDesdeAPI()
        {
            if (!File.Exists(pathDB))
            {
                var productos = new List<ProductoDatos>();
                foreach (int categoria in Enum.GetValues(typeof(CategoriaProducto)))
                {
                    var productosPorCategoria = productoService.GetProductosporCategoria(categoria);
                    productos.AddRange(productosPorCategoria);
                }

                var serializedData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                File.WriteAllText(pathDB, serializedData);
            }
        }
    }
}


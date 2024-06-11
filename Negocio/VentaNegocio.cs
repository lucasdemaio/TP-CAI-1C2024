using Datos;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Newtonsoft.Json;
using System.Net.Http;

namespace Negocio
{
    namespace Negocio
    {
        public class VentaNegocio
        {
            private VentaService ventaService = new VentaService();
            private ProductoNegocio productoNegocio = new ProductoNegocio();
            private string pathDB = @"C:\ElectroHogarDB\ventas.json";

            private const double ElectroHogarUmbralDescuento = 100000.0;
            private const double ElectroHogarPorcentajeDescuento = 0.05; // 5%

            public double CalcularDescuentoElectroHogar(List<ProductoDatos> productos)
            {
                double totalElectroHogar = productos
                    .Where(p => p.IdCategoria == 3)
                    .Sum(p => p.Precio * p.Cantidad);

                if (totalElectroHogar > ElectroHogarUmbralDescuento)
                {
                    return totalElectroHogar * ElectroHogarPorcentajeDescuento;
                }

                return 0.0;
            }

            public (double totalConDescuento, double descuentoElectroHogar) CalcularTotalConDescuento(List<ProductoDatos> productos, bool esPrimeraCompra)
            {
                double total = productos.Sum(p => p.Precio * p.Cantidad);
                double descuentoElectroHogar = CalcularDescuentoElectroHogar(productos);

                double descuentoPrimeraCompra = 0;
                if (esPrimeraCompra)
                {
                    descuentoPrimeraCompra = total * 0.05;
                }

                double totalConDescuento = total - descuentoElectroHogar - descuentoPrimeraCompra;

                return (totalConDescuento, descuentoElectroHogar);
            }

            public bool EsClienteNuevo(Guid clienteId)
            {
                List<VentaGET> ventas = ventaService.GetVentasPorCliente(clienteId);              
                return ventas.Count == 0;               
            }

            public void AgregarVenta(VentaAlta venta)
            {
                ventaService.AgregarVenta(venta);
                GuardarVentaLocal(venta);
            }

            private void GuardarVentaLocal(VentaAlta venta)
            {
                List<VentaAlta> ventas = new List<VentaAlta>();

                if (File.Exists(pathDB))
                {
                    var json = File.ReadAllText(pathDB);
                    ventas = JsonConvert.DeserializeObject<List<VentaAlta>>(json) ?? new List<VentaAlta>();
                }

                ventas.Add(venta);

                var serializedData = JsonConvert.SerializeObject(ventas, Formatting.Indented);
                File.WriteAllText(pathDB, serializedData);
            }

             public List<VentaGET> GetVentasPorCliente(Guid clienteId)
            {
                return ventaService.GetVentasPorCliente(clienteId);
            }

            public void DevolverVenta(VentaDevolucion devolucion)
            {
                ventaService.DevolverVenta(devolucion);
            }
        }
    }
}

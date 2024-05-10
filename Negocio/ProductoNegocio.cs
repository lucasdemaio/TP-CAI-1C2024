using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegocio
    {
        private ProductoService productoService = new ProductoService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public void agregarProducto(int idCategoria, string idProveedor, string nombre, double precio, int stock)
        {
            ProductoAlta altaProducto = new ProductoAlta(idCategoria, idAdministrador, idProveedor, nombre, precio, stock);
            productoService.AgregarProducto(altaProducto);
        }

        public void eliminarProducto(string idProducto)
        {
            ProductoBaja bajaProducto = new ProductoBaja(idProducto, idAdministrador);
            productoService.BorrarProducto(bajaProducto);
        }

        public List<ProductoDatos> listarProductos()
        {
            return productoService.getProductos();
        }

        public void modificarProducto(string idProducto, double precio, int stock)
        {
            ProductoModificacion producto = new ProductoModificacion(idProducto, idAdministrador, precio, stock);
            productoService.ModificarProducto(producto);
        }
    }
}

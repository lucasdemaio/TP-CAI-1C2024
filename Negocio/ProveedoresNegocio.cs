using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProveedoresNegocio
    {
        private ProveedorService proveedorService = new ProveedorService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";


        public List<ProveedoresDatos> listarProveedores()
        {
            return proveedorService.getProveedores();
        }

        public void agregarProveedor(string guidUsuarioString, string nombre, string apellido, string email, string cuit)
        {
            ProveedoresAlta altaProveedor = new ProveedoresAlta(guidUsuarioString, nombre, apellido, email, cuit);
            proveedorService.AgregarProveedor(altaProveedor);

        }

        public void borrarProveedor(Guid idProveedor)
        {            
            proveedorService.BajaProveedor(idProveedor, idAdministrador);
        }

        public void modificarProveedor(Guid idProveedor, string nombre, string apellido, string email, string cuit)
        {
            proveedorService.ModificarProveedor(idProveedor, idAdministrador,nombre, apellido, email, cuit);
        }
    }
}

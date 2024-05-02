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
        
        
        public List<ProveedoresDatos> listarProveedores()
        {
            return proveedorService.getProveedores();
        }

        public void agregarProveedor(string guidUsuarioString, string nombre, string apellido, string email, string cuit)
        {
            ProveedoresAlta altaProveedor = new ProveedoresAlta(guidUsuarioString, nombre, apellido, email, cuit);
            proveedorService.AgregarProveedor(altaProveedor);

        }
    }
}

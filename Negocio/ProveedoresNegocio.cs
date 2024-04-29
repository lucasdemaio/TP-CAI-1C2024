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
    }
}

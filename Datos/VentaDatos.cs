using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaDatos
    {
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Estado { get; set; }
        public Guid IdUsuario { get; set; }




    }
}

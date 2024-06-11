using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaGET
    {
        public Guid Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Estado { get; set; }
    }
}

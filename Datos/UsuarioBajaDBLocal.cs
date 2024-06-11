using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioBajaDBLocal
    {
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaBaja { get; set; }
     

        public UsuarioBajaDBLocal(string idUsuario, string nombreUsuario, string nombre, string apellido ,bool estado, DateTime fechaBaja)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Estado = estado;
            FechaBaja = fechaBaja;
        }
    }
}

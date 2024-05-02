using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioLogueado
    {
        public static string NombreUsuario { get; private set; }

        public static void SetNombreUsuario(string nombre)
        {
            NombreUsuario = nombre;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDBLocal
    {        
        string _nombreUsuario;
        string _contraseña;
        bool _estado;
        DateTime? _fechaCambioClave;

        public UsuarioDBLocal(string nombreUsuario, string contraseña, bool estado, DateTime? fechaCambioClave)
        {
            _nombreUsuario = nombreUsuario;
            _contraseña = contraseña;
            _estado = estado;
            _fechaCambioClave = fechaCambioClave;
        }

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public DateTime? FechaCambioClave { get => _fechaCambioClave; set => _fechaCambioClave = value; }

    }


}

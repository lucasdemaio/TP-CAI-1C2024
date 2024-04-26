using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioBaja
    {
        Guid _idUsuario;
        
        public UsuarioBaja(Guid idUsuario)
        {
            _idUsuario = idUsuario;
        }

        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }       

    }
}

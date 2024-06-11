using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProveedoresBaja
    {
        Guid _id;
        string _idUsuario;


        public ProveedoresBaja(Guid id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }

        public Guid Id { get => _id; set => _id = value; }
        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioBaja
    {
        string _id;
        Guid _idUsuario;        

        public UsuarioBaja(string id, Guid idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;
        }

        public string Id { get => _id; set => _id = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }       

    }
}

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
        string _idUsuario;


        public UsuarioBaja(string id, string idUsuario)
        {
            _id = id;
            _idUsuario = idUsuario;            
        }

        public string Id{ get => _id; set => _id = value; }
        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }


    }
}

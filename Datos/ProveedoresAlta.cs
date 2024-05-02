using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProveedoresAlta
    {
        public string _idUsuario { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public string _email { get; set; }
        public string _cuit { get; set; }        

        public ProveedoresAlta(string idUsuario, string nombre, string apellido, string email, string cuit)
        {            
            _idUsuario = idUsuario;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _cuit = cuit;
        }

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string CUIT { get => _cuit; set => _cuit = value; }    
        
        
    }
}

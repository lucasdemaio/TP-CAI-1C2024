using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public enum CategoriaProducto
    {
        Audio = 1,
        Celulares = 2,
        ElectroHogar = 3,
        Informatica = 4,
        SmartTV = 5,
        Desconocida = 6
    }

    public class ProveedoresDatos
    {
        Guid _id;
        List<int> _categorias;
        string _nombre;
        string _apellido;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        string _cuit;
        string _email;
        Guid _idUsuario;
        
        public ProveedoresDatos(Guid id, string nombre, DateTime fechaAlta, DateTime? fechaBaja ,string cuit, string email, string apellido, List<int> categorias, Guid idUsuario)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _cuit = cuit;
            _fechaAlta = fechaAlta;
            _fechaBaja = fechaBaja;
            _categorias = categorias;                 
            _idUsuario = idUsuario;            
        }


        public Guid Id { get => _id; set => _id = value; }

        public List<int> Categorias { get => _categorias; set => _categorias = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public string CUIT { get => _cuit; set => _cuit = value; }
        public string Email { get => _email; set => _email = value; }        
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
       

    }
}

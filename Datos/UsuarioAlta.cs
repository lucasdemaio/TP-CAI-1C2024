using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Datos
{
    public class UsuarioAlta
    {
        string _idUsuario;
        int _valorPerfil;
        string _nombre;
        string _apellido;
        int _dni;
        string _direccion;
        string _telefono;
        string _email;
        DateTime _fechaNacimiento;
        string _nombreUsuario;
        string _contraseña;
        DateTime? _fechaBaja;


        public UsuarioAlta(string idUsuario,int valorPerfil, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña, DateTime? fechaBaja)
        {
            _idUsuario = idUsuario;
            _valorPerfil = valorPerfil;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _fechaNacimiento = fechaNacimiento;
            _nombreUsuario = nombreUsuario;
            _contraseña = contraseña;
            _fechaBaja = fechaBaja;
        }

        
        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public int Host { get => _valorPerfil; set => _valorPerfil = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

    }
}

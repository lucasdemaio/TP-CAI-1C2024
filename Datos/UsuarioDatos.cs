    using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Datos
{
    public class Usuario
    {
        Guid _id;
        string _nombre;
        string _apellido;
        string _direccion;
        string _telefono;
        string _email;
        DateTime _fechaAlta;
        DateTime _fechaNacimiento;
        DateTime? _fechaBaja;
        string _nombreUsuario;
        int _host;
        int _dni;

        public Usuario(Guid id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta,
                        DateTime fechaNacimiento, DateTime? fechaBaja, string nombreUsuario, int host, int dni, string contrasena)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _fechaAlta = fechaAlta;
            _fechaNacimiento = fechaNacimiento;
            _fechaBaja = fechaBaja;
            _nombreUsuario = nombreUsuario;
            _host = host;
            _dni = dni;           
        }


        public Guid id { get => _id; set => _id = value; }
        public int Host { get => _host; set => _host = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

    }
}


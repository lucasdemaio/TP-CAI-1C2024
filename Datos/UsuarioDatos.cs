using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Datos
{
    public class Usuario
    {
        public enum Host
        {
            Vendedor = 1,
            Supervisor = 2,
            Administrador = 3
        }

        Guid _id;
        string _nombre;
        string _apellido;
        string _direccion;
        string _telefono;
        string _mail;
        DateTime _fechaAlta;
        DateTime _fechaNacimiento;
        DateTime? _fechaBaja;
        string _nombreUsuario;
        string _perfil;
        int _dni;


        public Usuario(Guid id, string nombre, string apellido, string direccion, string telefono, string mail, DateTime fechaAlta,
                        DateTime fechaNacimiento, DateTime? fechaBaja, string nombreUsuario, Host _perfil, int dni, string contrasena, string estado)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _mail = mail;
            _fechaAlta = fechaAlta;
            _fechaNacimiento = fechaNacimiento;
            _fechaBaja = fechaBaja;
            _nombreUsuario = nombreUsuario;
            _perfil = perfil;
            _dni = dni;           
        }




        public Guid id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime? fechaBaja { get; set; }
        public string nombreUsuario { get; set; }
        public Host perfil { get; set; }
        public int dni { get; set; }
        public string estado { get; set; }

    }    
}

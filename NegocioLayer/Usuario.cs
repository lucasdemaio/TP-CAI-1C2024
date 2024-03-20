using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioLayer
{

    public enum Perfil
    {
        Vendedor = 1,
        Supervisor = 2,
        Administrador = 3
    }

    public class Usuario
    {
        public Usuario(int id, string nombre, string apellido, string direccion, string telefono, string mail, DateTime fechaAlta,
                        DateTime fechaNacimiento, DateTime? fechaBaja, string username, Perfil perfil, int dNI, string clave)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Mail = mail;
            FechaAlta = fechaAlta;
            FechaNacimiento = fechaNacimiento;
            FechaBaja = fechaBaja;
            Username = username;
            Perfil = perfil;
            DNI = dNI;
            Clave = clave;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime? FechaBaja { get; set; } // Nullable DateTime
        public string Username { get; set; }
        public Perfil Perfil { get; set; }
        public int DNI { get; set; }
        public string Clave { get; set; }
    }

   
}

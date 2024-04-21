using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.Usuario;

namespace Datos
{
    public class UsuarioDBLocal
    {
        string _nombre;
        string _apellido;
        string _mail;
        DateTime _fechaAlta;
        DateTime _fechaNacimiento;
        DateTime? _fechaBaja;
        string _nombreUsuario;
        int _perfil;
        int _dni;
        string _contraseña;
        string _estado;





        public UsuarioDBLocal(string nombre, string apellido, string mail, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, string nombreUsuario, int perfil, int dni, string contraseña, string estado)
        {
            //_nombre = nombre;
            //_apellido = apellido;
            //_mail = mail;
            //_fechaAlta = fechaAlta;
            //_fechaNacimiento = fechaNacimiento;
            //_fechaBaja = fechaBaja;
            //_nombreUsuario = nombreUsuario;
            //_perfil = perfil;
            //_dni = dni;
            //_contraseña = contraseña;
            //_estado = estado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.fechaAlta = fechaAlta;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaBaja = fechaBaja;
            this.nombreUsuario = nombreUsuario;
            this.perfil = perfil;
            this.dni = dni;
            this.contraseña = contraseña;
            this.estado = estado;

        }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime? fechaBaja { get; set; }
        public string nombreUsuario { get; set; }
        public int perfil { get; set; }
        public int dni { get; set; }
        public string contraseña { get; set; }
        public string estado { get; set; }
    }
}

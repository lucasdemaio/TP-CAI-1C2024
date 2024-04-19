using System;
using System.Security.Cryptography;

namespace Datos
{
    public class Usuario
    {
        private string _contrasenaHash;

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
                        DateTime fechaNacimiento, DateTime? fechaBaja, string nombreUsuario, Host _perfil, int dni, string contrasena)
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

            SetContrasena(contrasena);
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime? fechaBaja { get; set; }
        public string nombreUsuario { get; set; }
        public Usuario.Host perfil { get; set; }
        public int dni { get; set; }


        public void SetContrasena(string contrasena)
        {
            // Generar un salt (sal) único para cada usuario (esto añade más seguridad)
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Aplicar hash a la contraseña utilizando el algoritmo PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(contrasena, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combinar salt y hash en una sola matriz
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convertir la matriz de bytes a una cadena base64
            _contrasenaHash = Convert.ToBase64String(hashBytes);
        }

        // Método para verificar si una contraseña ingresada es correcta
        public bool VerificarContrasena(string contrasena)
        {
            // Obtener la matriz de bytes del hash almacenado
            byte[] hashBytes = Convert.FromBase64String(_contrasenaHash);

            // Extraer salt de los primeros 16 bytes de hashBytes
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Calcular hash de la contraseña ingresada con el mismo salt
            var pbkdf2 = new Rfc2898DeriveBytes(contrasena, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Comparar los hashes
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }
            return true;
        }
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presentacion
{
    public class ValidadorUtilis
    {
        public string ValidarDatosUsuario(string nombreUsuario, string contraseña, int dni, string nombre, string apellido)
        {
            nombreUsuario = nombreUsuario.ToLower();
            nombre = nombre.ToLower();
            apellido = apellido.ToLower();

            // Verificar longitud y caracteres inválidos del nombre de usuario
            if (nombreUsuario.Length < 8 || nombreUsuario.Length > 15)
            {
                return "Error: El nombre de usuario debe tener entre 8 y 15 caracteres.";
            }
            if (nombreUsuario.Contains(nombre) || nombreUsuario.Contains(apellido))
            {
                return "Error: El nombre de usuario no puede contener el nombre o apellido del usuario.";
            }

            // Verificar longitud y composición de la contraseña
            if (contraseña.Length < 8 || contraseña.Length > 15)
            {
                return "Error: La contraseña debe tener entre 8 y 15 caracteres.";
            }
            if (!contraseña.Any(char.IsDigit) || !contraseña.Any(char.IsUpper))
            {
                return "Error: La contraseña debe contener al menos una letra mayúscula y un número.";
            }

            // Verificar rango válido del DNI
            if (dni < 0 || dni > 99999999)
            {
                return "Error: El DNI debe estar entre 0 y 99999999.";
            }

            // Si todas las validaciones pasan, devolver mensaje vacío
            return string.Empty;
        }






    }
}

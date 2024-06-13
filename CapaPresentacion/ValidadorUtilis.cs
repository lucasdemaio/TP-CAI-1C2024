using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presentacion
{
    public class ValidadorUtilis
    {
        public string ValidarDatosUsuario(string nombreUsuario, string contraseña, int dni, string nombre, string apellido, DateTime fechaNacimiento, int valorPerfil)
        {
            nombreUsuario = nombreUsuario.ToLower();
            nombre = nombre.ToLower();
            apellido = apellido.ToLower();

            if (nombreUsuario.Length < 8 || nombreUsuario.Length > 15)
            {
                return "Error: El nombre de usuario debe tener entre 8 y 15 caracteres.";
            }
            if (nombreUsuario.Contains(nombre) || nombreUsuario.Contains(apellido))
            {
                return "Error: El nombre de usuario no puede contener el nombre o apellido del usuario.";
            }
                        
            if (contraseña.Length < 8 || contraseña.Length > 15)
            {
                return "Error: La contraseña debe tener entre 8 y 15 caracteres.";
            }
            if (!contraseña.Any(char.IsDigit) || !contraseña.Any(char.IsUpper))
            {
                return "Error: La contraseña debe contener al menos una letra mayúscula y un número.";
            }
            
            if (dni < 1000000 || dni > 99999999 || dni == null)
            {
                return "Error: El DNI debe estar entre 1.000.000 y 99.999.999.";
            }
           return string.Empty;
        }


        public string ValidarCamposCompletos(Form form, Dictionary<Control, string> controlEtiquetaMap)
        {
            StringBuilder camposIncompletos = new StringBuilder();

            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    string etiqueta = "";
                    if (controlEtiquetaMap.TryGetValue(control, out etiqueta))
                    {
                        camposIncompletos.AppendLine($"El campo '{etiqueta}' no puede estar vacío.");
                    }
                    else
                    {
                        camposIncompletos.AppendLine($"El campo '{control.Name}' no puede estar vacío.");
                    }
                }
            }
            return camposIncompletos.ToString();
        }


        public string ValidarContraseña(string contraseñaActual, string nuevaContraseña)
        {
            if (contraseñaActual == nuevaContraseña)
            {
                return "Error: La nueva contraseña no puede ser igual a la contraseña actual.";
            }

            // Verificar si la nueva contraseña coincide con la contraseña actual
            if (contraseñaActual == nuevaContraseña)
            {
                return "Error: La nueva contraseña no puede ser igual a la contraseña actual.";
            }

            // Verificar si la contraseña cumple con los requisitos de longitud y caracteres
            if (nuevaContraseña.Length < 8 || nuevaContraseña.Length > 15)
            {
                return "Error: La contraseña debe tener entre 8 y 15 caracteres.";
            }
            if (!nuevaContraseña.Any(char.IsDigit) || !nuevaContraseña.Any(char.IsUpper))
            {
                return "Error: La contraseña debe contener al menos una letra mayúscula y un número.";
            }

            // Si la contraseña cumple con todos los requisitos, retornar una cadena vacía
            return "";
        }








    }
}

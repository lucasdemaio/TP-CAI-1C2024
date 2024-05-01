using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using static Datos.Usuario;

namespace Negocio
{
    public class UsuarioNegocio
    {
              
        private UsuarioService usuarioService = new UsuarioService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";        

        
        public void agregarUsuario(int valorPerfil, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            UsuarioAlta altaUsuario = new UsuarioAlta(idAdministrador, valorPerfil, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña, null);
            usuarioService.AgregarUsuario(altaUsuario);           
        }

        public void agregarUsuarioDBLocal(string nombreUsuario, string contraseña)
        {
            UsuarioDBLocal altaUsuarioDBLocal = new UsuarioDBLocal(nombreUsuario, contraseña, false, null);
            usuarioService.EscribirUsuarioDBLocal(altaUsuarioDBLocal);
        }



        public void borrarUsuario(string idUsuario)
        {
            UsuarioBaja bajausuario = new UsuarioBaja(idUsuario, idAdministrador);
            usuarioService.BajaUsuario(bajausuario);
        }

        public void borrarUsuarioDBLocal(string nombreUsuario)
        {            
            usuarioService.EliminarUsuarioDBLocal(nombreUsuario);
        }

        public List<Usuario> listarUsuarios()
        {
            return usuarioService.GetUsuarios(idAdministrador);
        }


        public int Login(string usuario, string clave)
        {   
            try
            {                
                return usuarioService.Login(usuario, clave, idAdministrador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
            }
        }

        public bool VerificarPrimerLogin(string nombreUsuario)
        {
            return usuarioService.VerificarPrimerLogin(nombreUsuario);
        }

        public bool VerificarExpiracionContraseña(string nombreUsuario)
        {
            return usuarioService.VerificarExpiracionContraseña(nombreUsuario);
        }


        public void CambiarContraseña(string usuario, string contraseñaActual, string nuevaContraseña)
        {
            int loginResult = Login(usuario, contraseñaActual);
            if (loginResult != -1)
            {
                string validacionContraseña = ValidarContraseña(contraseñaActual, nuevaContraseña);
                if (validacionContraseña != "")
                {
                    throw new Exception(validacionContraseña);
                }
                usuarioService.CambiarContraseña(usuario, contraseñaActual, nuevaContraseña);
                usuarioService.ActualizarDBLocal(usuario, nuevaContraseña);
            }
            else
            {
                throw new Exception("La contraseña actual es incorrecta");
            }
        }

        internal string ValidarContraseña(string contraseñaActual, string nuevaContraseña)
        {
            if (contraseñaActual == nuevaContraseña)
            {
                return "Error: La nueva contraseña no puede ser igual a la contraseña actual.";
            }

            if (nuevaContraseña.Length < 8 || nuevaContraseña.Length > 15)
            {
                return "Error: La contraseña debe tener entre 8 y 15 caracteres.";
            }
            if (!nuevaContraseña.Any(char.IsDigit) || !nuevaContraseña.Any(char.IsUpper))
            {
                return "Error: La contraseña debe contener al menos una letra mayúscula y un número.";
            }
            return "";
        }
      
    }
}


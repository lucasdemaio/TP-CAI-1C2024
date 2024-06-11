using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;
using Persistencia;
using static Datos.Usuario;

namespace Negocio
{
    public class UsuarioNegocio
    {
              
        private UsuarioService usuarioService = new UsuarioService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";
        private string pathDB = @"C:\ElectroHogarDB\usuarios_baja.json";

        public void agregarUsuario(string guidUsuarioString, int valorPerfil, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            UsuarioAlta altaUsuario = new UsuarioAlta(guidUsuarioString, valorPerfil, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña, null);
            try
            {
                usuarioService.AgregarUsuario(altaUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario", ex);
            }
        }

        public void agregarUsuarioDBLocal(string nombreUsuario, string contraseña)
        {
            UsuarioDBLocal altaUsuarioDBLocal = new UsuarioDBLocal(nombreUsuario, contraseña, false, null);
            usuarioService.EscribirUsuarioDBLocal(altaUsuarioDBLocal);
        }

        public void borrarUsuario(string idUsuario, string guidUsuarioString, string nombreUsuario, string nombre, string apellido)
        {
            UsuarioBaja bajausuario = new UsuarioBaja(idUsuario, guidUsuarioString);
            try
            {
                usuarioService.BajaUsuario(bajausuario);
                GuardarUsuarioBajaLocal(idUsuario, nombreUsuario, nombre, apellido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja el usuario", ex);
            }
        }

        public void borrarUsuarioDBLocal(string nombreUsuario)
        {            
            usuarioService.EliminarUsuarioDBLocal(nombreUsuario);
        }

        private void GuardarUsuarioBajaLocal(string idUsuario, string nombreUsuario, string nombre, string apellido)
        {
            List<UsuarioBajaDBLocal> usuariosBaja = new List<UsuarioBajaDBLocal>();

            if (File.Exists(pathDB))
            {
                var json = File.ReadAllText(pathDB);
                usuariosBaja = JsonConvert.DeserializeObject<List<UsuarioBajaDBLocal>>(json) ?? new List<UsuarioBajaDBLocal>();
            }

            usuariosBaja.Add(new UsuarioBajaDBLocal(idUsuario, nombreUsuario, nombre, apellido, false, DateTime.Now));

            var serializedData = JsonConvert.SerializeObject(usuariosBaja, Formatting.Indented);
            File.WriteAllText(pathDB, serializedData);
        }

        public void EliminarUsuarioDeBajasJson(string idUsuario)
        {
            List<UsuarioBajaDBLocal> usuariosBaja = new List<UsuarioBajaDBLocal>();

            if (File.Exists(pathDB))
            {
                var json = File.ReadAllText(pathDB);
                usuariosBaja = JsonConvert.DeserializeObject<List<UsuarioBajaDBLocal>>(json) ?? new List<UsuarioBajaDBLocal>();
            }

            var usuarioParaEliminar = usuariosBaja.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuarioParaEliminar != null)
            {
                usuariosBaja.Remove(usuarioParaEliminar);
            }

            var serializedData = JsonConvert.SerializeObject(usuariosBaja, Formatting.Indented);
            File.WriteAllText(pathDB, serializedData);
        }

        public void ReactivarUsuario(string idUsuario, string guidUsuario)
        {
            try
            {
                usuarioService.ReactivarUsuario(idUsuario, guidUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al reactivar el usuario", ex);
            }
        }

        public List<UsuarioBajaDBLocal> ObtenerUsuariosDadosDeBaja()
        {
            if (File.Exists(pathDB))
            {
                var json = File.ReadAllText(pathDB);
                return JsonConvert.DeserializeObject<List<UsuarioBajaDBLocal>>(json) ?? new List<UsuarioBajaDBLocal>();
            }
            return new List<UsuarioBajaDBLocal>();
        }

        public void borrarUsuarioPorLoginFallido(string nombreUsuario)
        {
            List<Usuario> usuarios = usuarioService.GetUsuarios(idAdministrador);
            Usuario usuario = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            if (usuario != null)
            {
                string idUsuario = usuario.id.ToString();
                string nombreusuario = usuario.NombreUsuario;
                string nombre = usuario.Nombre;
                string apellido = usuario.Apellido;                

                borrarUsuario(idUsuario, idAdministrador, nombreUsuario, nombre, apellido);
            }
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

        public bool VerificarExpiracionContraseña(string usuario)
        {
            return usuarioService.VerificarExpiracionContraseña(usuario);
        }


        public void CambiarContraseña(string usuario, string contraseñaActual, string nuevaContraseña)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar la contraseña en la capa de negocio.", ex);
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


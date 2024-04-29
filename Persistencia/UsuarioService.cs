using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace Persistencia
{
    public class UsuarioService
    {
        public List<UsuarioAlta> GetUsuarios(string idAdministrador)
        {
            String path = $"/api/Usuario/TraerUsuariosActivos?id={idAdministrador}";

            List<UsuarioAlta> usuarios = new List<UsuarioAlta>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<UsuarioAlta> listadoUsuarios = JsonConvert.DeserializeObject<List<UsuarioAlta>>(contentStream);
                    return listadoUsuarios;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return usuarios;

        }       


        public void AgregarUsuario(UsuarioAlta altaUsuario)
        {
            String path = "/api/Usuario/AgregarUsuario";

            var jsonRequest = JsonConvert.SerializeObject(altaUsuario);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }


        public void EscribirUsuarioDBLocal(UsuarioDBLocal usuario)
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";

            using (StreamWriter writer = new StreamWriter(docpath, true))
            {
                //foreach (UsuarioDBLocal usuario in usuarios)
                writer.WriteLine(usuario.NombreUsuario + ";" + usuario.Contraseña + ";" + usuario.Estado + ";" + usuario.FechaCambioClave);
            }
        }

        public void LeerDBUsuarioLocal()
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";

            using (StreamReader file = new StreamReader(docpath))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] datos = ln.Split(';');
                    string nombreUsuario = datos[0];
                    string contraseña = datos[1];
                    bool estado = Convert.ToBoolean(datos[2]);
                    DateTime fechaCambioClave = Convert.ToDateTime(datos[3]);
                  
                }
                file.Close();
            }
        }

        public void ActualizarDBLocal(string usuario, string nuevaContraseña)
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";
            String tempFile = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(docpath))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string ln;
                while ((ln = reader.ReadLine()) != null)
                {
                    string[] datos = ln.Split(';');
                    string usuarioArchivo = datos[0].Trim(); // El primer elemento es el nombre de usuario
                    string contraseña = datos[1].Trim(); // El segundo elemento es la contraseña

                    if (usuarioArchivo == usuario)
                    {
                        // Si encontramos el usuario, actualizamos los datos
                        writer.WriteLine($"{usuario};{nuevaContraseña};True;{DateTime.Now.ToString()}");
                    }
                    else
                    {
                        // Mantenemos los datos como estaban
                        writer.WriteLine(ln);
                    }
                }
            }

            // Reemplazamos el archivo original con el temporal
            File.Delete(docpath);
            File.Move(tempFile, docpath);
        }

        public bool VerificarPrimerLogin(string nombreUsuario)
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";

            if (File.Exists(docpath)) // Verifica si el archivo existe
            {
                using (StreamReader file = new StreamReader(docpath))
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        string[] datos = ln.Split(';');
                        if (datos.Length >= 2) // Verifica si hay al menos dos elementos en la línea
                        {
                            string usuario = datos[0].Trim(); // El primer elemento es el nombre de usuario
                            string contraseña = datos[1].Trim(); // El segundo elemento es la contraseña                                                       
                              
                            if (usuario == nombreUsuario && contraseña == "CAI20232")
                            {
                                return true;                                    
                            }                          
                        }
                    }
                }
            }
            return false;
        }

        public bool VerificarExpiracionContraseña(string nombreUsuario)
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";

            if (File.Exists(docpath)) // Verifica si el archivo existe
            {
                using (StreamReader file = new StreamReader(docpath))
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        string[] datos = ln.Split(';');
                        if (datos.Length >= 4) // Verifica si hay al menos dos elementos en la línea
                        {
                            string usuario = datos[0].Trim(); // El primer elemento es el nombre de usuario
                            string contraseña = datos[1].Trim(); // El segundo elemento es la contraseña
                            bool estado = Convert.ToBoolean(datos[2].Trim()); // El tercer elemento es el estado
                            DateTime fechaCambioClave;

                            if (DateTime.TryParse(datos[3].Trim(), out fechaCambioClave)) // El cuarto elemento es la fecha de cambio de clave
                            {
                                // Si han pasado más de 30 días desde la última fecha de cambio de contraseña
                                if ((DateTime.Now - fechaCambioClave).TotalDays > 30)
                                {
                                    // Se debe cambiar la contraseña
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }


        public int Login(string usuario, string clave, string idAdministrador)
        {
            try
            {
                var datosUsuario = new
                {
                    nombreUsuario = usuario,
                    contraseña = clave
                };

                string jsonRequest = JsonConvert.SerializeObject(datosUsuario);

                HttpResponseMessage response = WebHelper.Post("/api/Usuario/Login", jsonRequest);

                if (response.IsSuccessStatusCode)
                {
                    List<UsuarioAlta> usuarios = GetUsuarios(idAdministrador);
                    UsuarioAlta usuarioLogueado = usuarios.FirstOrDefault(u => u.NombreUsuario == usuario);

                    int perfilUsuario = usuarioLogueado.Host;
                    return perfilUsuario;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar iniciar sesión: " + ex.Message);
            }
        }

        public void CambiarContraseña(string usuario, string contraseña, string contraseñaNueva)
        {
            String path = "/api/Usuario/CambiarContraseña";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", usuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);
   
            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void BajaUsuario(UsuarioBaja usuarioBaja)
        {
            String path = "/api/Usuario/BajaUsuario?id=" + usuarioBaja;

            try
            {
                HttpResponseMessage response = WebHelper.Delete(path);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

    }
}

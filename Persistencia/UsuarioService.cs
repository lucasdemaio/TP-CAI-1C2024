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
        public List<Usuario> GetUsuarios(string idAdministrador)
        {
            String path = $"/api/Usuario/TraerUsuariosActivos?id={idAdministrador}";

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<Usuario> listadoUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contentStream);
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
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al comunicarse con el servicio: {ex.Message}", ex);
            }
        }


        public void EscribirUsuarioDBLocal(UsuarioDBLocal usuario)
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";

            using (StreamWriter writer = new StreamWriter(docpath, true))
            {
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

        //public void ActualizarDBLocal(string usuario, string nuevaContraseña)
        //{
        //    String docpath = @"/ElectroHogarDB/Usuario.txt";
        //    String tempFile = Path.GetTempFileName();

        //    using (StreamReader reader = new StreamReader(docpath))
        //    using (StreamWriter writer = new StreamWriter(tempFile))
        //    {
        //        string ln;
        //        while ((ln = reader.ReadLine()) != null)
        //        {
        //            string[] datos = ln.Split(';');
        //            string usuarioArchivo = datos[0].Trim();
        //            string contraseña = datos[1].Trim();

        //            if (usuarioArchivo == usuario)
        //            {
        //                writer.WriteLine($"{usuario};{nuevaContraseña};True;{DateTime.Now.ToString()}");
        //            }
        //            else
        //            {
        //                writer.WriteLine(ln);
        //            }
        //        }
        //    }
        //    File.Delete(docpath);
        //    File.Move(tempFile, docpath);
        //}

        public void ActualizarDBLocal(string usuario, string nuevaContraseña)
        {
            String docpath = @"C:\ElectroHogarDB\Usuario.txt";
            String tempFile = Path.GetTempFileName();

            try
            {
                if (!File.Exists(docpath))
                {
                    throw new FileNotFoundException("El archivo de base de datos local no existe.");
                }

                using (StreamReader reader = new StreamReader(docpath))
                using (StreamWriter writer = new StreamWriter(tempFile))
                {
                    string ln;
                    bool usuarioEncontrado = false;
                    while ((ln = reader.ReadLine()) != null)
                    {
                        string[] datos = ln.Split(';');
                        string usuarioArchivo = datos[0].Trim();

                        if (usuarioArchivo == usuario)
                        {
                            writer.WriteLine($"{usuario};{nuevaContraseña};True;{DateTime.Now}");
                            usuarioEncontrado = true;
                        }
                        else
                        {
                            writer.WriteLine(ln);
                        }
                    }

                    if (!usuarioEncontrado)
                    {
                        throw new Exception("El usuario no fue encontrado en la base de datos local.");
                    }
                }

                File.Delete(docpath);
                File.Move(tempFile, docpath);
            }
            catch (Exception ex)
            {
                File.Delete(tempFile);
                throw new Exception("Error al actualizar la base de datos local.", ex);
            }
        }





        public void EliminarUsuarioDBLocal(string nombreUsuario)
        {
            string docpath = @"/ElectroHogarDB/Usuario.txt";
            string tempFile = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader(docpath))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string ln;
                while ((ln = reader.ReadLine()) != null)
                {
                    string[] datos = ln.Split(';');
                    string usuarioArchivo = datos[0].Trim();

                    if (usuarioArchivo != nombreUsuario)
                    {
                        writer.WriteLine(ln);
                    }
                }
            }
            File.Delete(docpath);
            File.Move(tempFile, docpath);
        }

        public bool VerificarPrimerLogin(string nombreUsuario)
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";

            if (File.Exists(docpath))
            {
                using (StreamReader file = new StreamReader(docpath))
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        string[] datos = ln.Split(';');
                        if (datos.Length >= 2)
                        {
                            string usuario = datos[0].Trim();
                            string contraseña = datos[1].Trim();                                                      
                              
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

        public bool VerificarExpiracionContraseña(string usuario)
        {
            String docpath = @"/ElectroHogarDB/Usuario.txt";

            if (File.Exists(docpath))
            {
                using (StreamReader file = new StreamReader(docpath))
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        string[] datos = ln.Split(';');
                        if (datos.Length >= 4)
                        {
                            string user = datos[0].Trim();
                            string contraseña = datos[1].Trim();
                            bool estado = Convert.ToBoolean(datos[2].Trim());
                            DateTime fechaCambioClave;

                            if (user == usuario && estado && DateTime.TryParse(datos[3].Trim(), out fechaCambioClave))
                            {
                                if ((DateTime.Now - fechaCambioClave).TotalDays > 30)
                                {
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
                    List<Usuario> usuarios = GetUsuarios(idAdministrador);
                    Usuario usuarioLogueado = usuarios.FirstOrDefault(u => u.NombreUsuario == usuario);

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
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar la contraseña en la capa de servicio.", ex);
            }
        }

        public void BajaUsuario(UsuarioBaja bajausuario)
        {
            String path = "/api/Usuario/BajaUsuario";

            var jsonRequest = JsonConvert.SerializeObject(bajausuario);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al comunicarse con el servicio: {ex.Message}", ex);
            }
        }

        public void ReactivarUsuario(string idUsuario, string guidUsuario)
        {
            String path = "/api/Usuario/ReactivarUsuario";            
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idUsuario);
            map.Add("idUsuario", guidUsuario);            

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
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al comunicarse con el servicio: {ex.Message}", ex);
            }
        }

    }
}

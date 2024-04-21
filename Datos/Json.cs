using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;
using System.IO;


namespace Datos
{
    public class Json   
    {
        public void GuardarUsuarioJson(UsuarioDBLocal usuarioDBLocal)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBLocal", "Usuarios.json");
                string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DBLocal\Usuarios.json");
                //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DBLocal\Usuarios.json");

                             
                //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Datos\Usuarios.json");

                //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\Datos\Usuarios.json");
                //string sFilePath = Path.GetFullPath(path);

                //string directoryPath = @"C:\Users\lucas\OneDrive\Documentos\Facultad\1C 2024\CAI\Practica\TP\Datos";
                //string fileName = "Usuarios.json";
                //string path = Path.Combine(directoryPath, fileName);

                //string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
                //string fileName = "Usuarios.json";
                //string path = Path.Combine(directoryPath, fileName);


                // Serializa el objeto UsuarioDatos a JSON
                string jsonUsuario = JsonConvert.SerializeObject(usuarioDBLocal);

                // Escribe el JSON en el archivo
                File.WriteAllText(path, jsonUsuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el archivo JSON: " + ex.Message);
            }
        }
    }
}

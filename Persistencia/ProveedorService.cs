using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ProveedorService
    {
        public void AgregarProveedor(ProveedoresAlta altaProveedor)
        {
            String path = "/api/Proveedor/AgregarProveedor";

            var jsonRequest = JsonConvert.SerializeObject(altaProveedor);

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

        public void BajaProveedor(Guid idProveedor, string idAdministrador)
        {
            String path = "/api/Proveedor/BajaProveedor";

            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
            map.Add("idUsuario", idAdministrador);
           
            var jsonRequest = JsonConvert.SerializeObject(map);

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
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

        }

        public List<ProveedoresDatos> getProveedores()
        {
            String path = "/api/Proveedor/TraerProveedores";
            List<ProveedoresDatos> proveedores = new List<ProveedoresDatos>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ProveedoresDatos> listadoProveedores = JsonConvert.DeserializeObject<List<ProveedoresDatos>>(contentStream);
                    return listadoProveedores;
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
            return proveedores;

        }

        public void ModificarProveedor(Guid idProveedor, string idUsuario, string nombre, string apellido, string email, string cuit)
        {
            String path = "/api/Proveedor/ModificarProveedor";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
            map.Add("idUsuario", idUsuario);
            map.Add("nombre", nombre);
            map.Add("apellido", apellido);
            map.Add("email", email);
            map.Add("cuit", cuit);


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
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;
using Persistencia;


namespace Negocio
{
    public class ClienteNegocio
    {
        private ClienteService clienteService = new ClienteService();

        public void agregarCliente(string guidUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento)
        {
            ClienteAlta altaCliente = new ClienteAlta(guidUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, "Lucas De Maio");
            try
            {
                clienteService.AgregarCliente(altaCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear alta del Cliente", ex);
            }
        }

        public void modificarCliente(Guid idCliente, string direccion, string telefono, string email)
        {
            try
            {
                clienteService.ModificarCliente(idCliente, direccion, telefono, email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el cliente", ex);
            }
        }

        public List<Cliente> listarClientes()
        {
            return clienteService.getClientes();
        }

        public void borrarCliente(Guid idCliente)
        {
            try
            {
                clienteService.BorrarCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente", ex);
            }
        }
        public void reactivarCliente(Guid idCliente)
        {
            try
            {
                clienteService.ReactivarCiente(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al reactivar el cliente", ex);
            }
        }

        public void GuardarClienteEliminado(Cliente cliente)
        {
            string path = @"C:\ElectroHogarDB\ClienteBajas.txt";
            string contenido = $"{cliente.Id}, {cliente.Nombre}, {cliente.Apellido}, {cliente.Dni}\n";

            string directorio = Path.GetDirectoryName(path);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(path, contenido);
        }

        public List<string> ObtenerClientesEliminados()
        {
            string path = @"C:\ElectroHogarDB\ClienteBajas.txt";
            List<string> clientesParaComboBox = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length < 4) continue;

                        string idCliente = parts[0].Trim();
                        string nombre = parts[1].Trim();
                        string apellido = parts[2].Trim();
                        string dni = parts[3].Trim();
                        string displayText = $"{apellido}, {nombre} - DNI: {dni}, {idCliente}";
                        clientesParaComboBox.Add(displayText);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo de clientes eliminados: " + ex.Message);
            }

            return clientesParaComboBox;
        }

        public void EliminarClienteReactivadoDeTxt(Guid idCliente)
        {
            string path = @"C:\ElectroHogarDB\ClienteBajas.txt";
            string tempFile = Path.GetTempFileName();

            try
            {
                var linesToKeep = File.ReadAllLines(path)
                                      .Where(line => {
                                          string lineId = line.Split(',')[0].Trim(); 
                                          return !lineId.Equals(idCliente.ToString(), StringComparison.OrdinalIgnoreCase);
                                      }).ToList();

                File.WriteAllLines(tempFile, linesToKeep);

                File.Delete(path);
                File.Move(tempFile, path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar cliente del archivo de bajas: " + ex.Message);
                throw;
            }
        }
    }
}

using Datos;
using Newtonsoft.Json;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Negocio
{
    public class ProveedoresNegocio
    {
        private ProveedorService proveedorService = new ProveedorService();
        private string pathDB = @"C:\ElectroHogarDB\proveedores.json";

        public List<ProveedoresDatos> listarProveedores()
        {
            return proveedorService.getProveedores();
        }

        public void agregarProveedor(string guidUsuarioString, string nombre, string apellido, string email, string cuit, List<int> categorias)
        {
            ProveedoresAlta altaProveedor = new ProveedoresAlta(guidUsuarioString, nombre, apellido, email, cuit);
            try
            {
                proveedorService.AgregarProveedor(altaProveedor);
                GuardarProveedorLocal(new ProveedoresDatos(Guid.Empty, nombre, DateTime.Now, null, cuit, email, apellido, categorias, Guid.Parse(guidUsuarioString)));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el proveedor", ex);
            }
        }

        private void GuardarProveedorLocal(ProveedoresDatos proveedor)
        {
            List<ProveedoresDatos> proveedores = new List<ProveedoresDatos>();
            if (File.Exists(pathDB))
            {
                var json = File.ReadAllText(pathDB);
                proveedores = JsonConvert.DeserializeObject<List<ProveedoresDatos>>(json) ?? new List<ProveedoresDatos>();
            }

            proveedores.Add(proveedor);

            var serializedData = JsonConvert.SerializeObject(proveedores, Formatting.Indented);
            File.WriteAllText(pathDB, serializedData);
        }

        public void borrarProveedor(Guid idProveedor, Guid idUsuario, string CUIT)
        {
            try
            {
                proveedorService.BajaProveedor(idProveedor, idUsuario);
                ActualizarFechaBajaProveedorPorCuit(CUIT);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el proveedor", ex);
            }
        }

        private void ActualizarFechaBajaProveedorPorCuit(string CUIT)
        {
            if (File.Exists(pathDB))
            {
                var json = File.ReadAllText(pathDB);
                var proveedores = JsonConvert.DeserializeObject<List<ProveedoresDatos>>(json);

                var proveedor = proveedores.FirstOrDefault(p => p.CUIT == CUIT);
                if (proveedor != null)
                {
                    proveedor.FechaBaja = DateTime.Now;

                    var serializedData = JsonConvert.SerializeObject(proveedores, Formatting.Indented);
                    File.WriteAllText(pathDB, serializedData);
                }
            }
        }

        public void ActualizarProveedorDbLocal(string cuit, string nombre, string apellido, string email, List<int> categorias)
        {
            string path = @"C:\ElectroHogarDB\proveedores.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var proveedores = JsonConvert.DeserializeObject<List<ProveedoresDatos>>(json) ?? new List<ProveedoresDatos>();

                var proveedor = proveedores.FirstOrDefault(p => p.CUIT == cuit);
                if (proveedor != null)
                {
                    proveedor.Nombre = nombre;
                    proveedor.Apellido = apellido;
                    proveedor.Email = email;
                    proveedor.Categorias = categorias;

                    var serializedData = JsonConvert.SerializeObject(proveedores, Formatting.Indented);
                    File.WriteAllText(path, serializedData);
                }
            }
        }

        public void modificarProveedor(Guid idProveedor, Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            try
            {
                proveedorService.ModificarProveedor(idProveedor, idUsuario, nombre, apellido, email, cuit);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el proveedor", ex);
            }
        }

        public Dictionary<int, List<ProveedoresDatos>> LeerProveedoresPorCategoria()
        {
            string path = @"C:\ElectroHogarDB\proveedores.json";
            var proveedoresPorCategoria = new Dictionary<int, List<ProveedoresDatos>>();

            try
            {
                var json = File.ReadAllText(path);
                var proveedores = JsonConvert.DeserializeObject<List<ProveedoresDatos>>(json);

                foreach (var categoria in Enum.GetValues(typeof(CategoriaProducto)).Cast<CategoriaProducto>())
                {
                    if (categoria == CategoriaProducto.Desconocida)
                    {
                        proveedoresPorCategoria[(int)categoria] = proveedores
                            .Where(p => p.Categorias == null || !p.Categorias.Any())
                            .ToList();
                    }
                    else
                    {
                        proveedoresPorCategoria[(int)categoria] = proveedores
                            .Where(p => p.Categorias != null && p.Categorias.Contains((int)categoria))
                            .ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer proveedores del archivo JSON: " + ex.Message);
            }

            return proveedoresPorCategoria;
        }

        public void reactivarProveedor(Guid idProveedor, Guid idUsuario, string cuit)
        {
            try
            {
                proveedorService.ReactivarProveedor(idProveedor, idUsuario);
                ReactivarProveedorDBLocal(cuit);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al reactivar el proveedor", ex);
            }
        }

        private void ReactivarProveedorDBLocal(string cuit)
        {
            string path = @"C:\ElectroHogarDB\proveedores.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var proveedores = JsonConvert.DeserializeObject<List<ProveedoresDatos>>(json) ?? new List<ProveedoresDatos>();

                var proveedor = proveedores.FirstOrDefault(p => p.CUIT == cuit);
                if (proveedor != null)
                {
                    Console.WriteLine($"Proveedor encontrado: {proveedor.Nombre} {proveedor.Apellido} con FechaBaja actual: {proveedor.FechaBaja}");
                    proveedor.FechaBaja = null;
                    Console.WriteLine($"Proveedor actualizado con FechaBaja: {proveedor.FechaBaja}");

                    var serializedData = JsonConvert.SerializeObject(proveedores, Formatting.Indented);
                    File.WriteAllText(path, serializedData);
                    Console.WriteLine("Archivo JSON actualizado correctamente.");
                }
                else
                {
                    Console.WriteLine("Proveedor no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Archivo JSON no encontrado.");
            }
        }

        public bool ExisteJsonProveedores()
        {
            return File.Exists(pathDB);
        }

        public void CrearJsonProveedoresDesdeApi()
        {
            var proveedores = listarProveedores();
            var serializedData = JsonConvert.SerializeObject(proveedores, Formatting.Indented);
            File.WriteAllText(pathDB, serializedData);
        }
    }
}

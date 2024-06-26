﻿using Datos;
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
    public class ProductoService
    {
        public void AgregarProducto(ProductoAlta altaProducto)
        {
            String path = "/api/Producto/AgregarProducto";

            var jsonRequest = JsonConvert.SerializeObject(altaProducto);

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

        public void BorrarProducto(ProductoBaja bajaProducto)
        {
            String path = "/api/Producto/BajaProducto";

            var jsonRequest = JsonConvert.SerializeObject(bajaProducto);

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
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al comunicarse con el servicio: {ex.Message}", ex);
            }
        }    

        public List<ProductoDatos> getProductos()
        {
            String path = "/api/Producto/TraerProductos";
            List<ProductoDatos> productos = new List<ProductoDatos>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ProductoDatos> listadoProductos = JsonConvert.DeserializeObject<List<ProductoDatos>>(contentStream);
                    return listadoProductos;
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
            return productos;

        }

        public List<ProductoDatos> GetProductosporCategoria(int categoria)
        {
            String path = $"/api/Producto/TraerProductosPorCategoria?catnum={categoria}";
                       

            List <ProductoDatos> productos = new List<ProductoDatos>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<ProductoDatos> listadoproductos = JsonConvert.DeserializeObject<List<ProductoDatos>>(contentStream);
                    return listadoproductos;
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
            return productos;

        }

        public void ModificarProducto(ProductoModificacion producto)
        {
            String path = "/api/Producto/ModificarProducto";
            
            var jsonRequest = JsonConvert.SerializeObject(producto);

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
                throw new Exception($"Error al comunicarse con el servicio: {ex.Message}", ex);
            }
        }

        public void ReactivarProducto(ProductoReactivar producto)
        {
            String path = "/api/Producto/ReactivarProducto";

            var jsonRequest = JsonConvert.SerializeObject(producto);

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
                throw new Exception($"Error al comunicarse con el servicio: {ex.Message}", ex);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProveedoresDatos
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public Guid IdUsuario { get; set; }
        public List<ProductoCategoria> Categorias { get; set; } // Lista de categorías de productos

        public ProveedoresDatos()
        {
            Categorias = new List<ProductoCategoria>();
        }

        public void AgregarCategoriaProducto(Guid idCategoria, string descripcion)
        {
            Categorias.Add(new ProductoCategoria { Id = idCategoria, Descripcion = descripcion });
        }
    }
}

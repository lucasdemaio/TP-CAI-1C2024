using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos
    {
        public Guid Id { get; set; }
        public Guid IdCategoria { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public Guid IdUsuario { get; set; }
        public Guid IdProveedor { get; set; }

        // Constructor
        public ProductoDatos(Guid idCategoria, string nombre, double precio, int stock, Guid idUsuario, Guid idProveedor)
        {
            Id = Guid.NewGuid();
            IdCategoria = idCategoria;
            Nombre = nombre;
            FechaAlta = DateTime.Now;
            Precio = precio;
            Stock = stock;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
        }

    }
}

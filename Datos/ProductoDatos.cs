using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos
    {
        Guid _id;
        int _idCategoria;
        string _nombre;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        double _precio;
        int _stock;
        Guid _idUsuario;
        Guid _idProveedor;

        public ProductoDatos(Guid id, int idCategoria, string nombre, double precio, int stock, Guid idUsuario, Guid idProveedor)
        {
            _id = id;
            _idCategoria = idCategoria;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _idUsuario = idUsuario;
            _idProveedor = idProveedor;
        }

        public Guid Id { get => _id; set => _id = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }

    }
}

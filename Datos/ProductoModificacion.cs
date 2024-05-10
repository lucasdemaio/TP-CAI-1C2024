using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoModificacion
    {
        string _id;
        string _idUsuario;
        double _precio;
        int _stock;


        public ProductoModificacion(string id, string idUsuario, double precio, int stock)
        {
            _id = id;
            _idUsuario = idUsuario;
            _precio = precio;
            _stock = stock;
        }
        public string Id { get => _id; set => _id = value; }
        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

    }


}

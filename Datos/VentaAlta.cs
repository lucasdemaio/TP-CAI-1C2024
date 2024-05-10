using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaAlta
    {
        string _idCliente;
        string _idUsuario;
        string _idProducto;
        int _cantidad;

        public VentaAlta(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            _idCliente = idCliente;
            _idUsuario = idUsuario;
            _idProducto = idProducto;
            _cantidad = cantidad;
        }


        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public string IdUsuaro { get => _idUsuario; set => _idUsuario = value; }
        public string IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

    }
}

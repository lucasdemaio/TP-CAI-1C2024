using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaAlta
    {
        private string _idCliente;
        private string _idUsuario;
        private string _idProducto;
        private int _cantidad;
        private double _montoTotal;
        private DateTime _fechaVenta;

        public VentaAlta(string idCliente, string idUsuario, string idProducto, int cantidad, double montoTotal, DateTime fechaVenta)
        {
            _idCliente = idCliente;
            _idUsuario = idUsuario;
            _idProducto = idProducto;
            _cantidad = cantidad;
            _montoTotal = montoTotal;
            _fechaVenta = fechaVenta;
            FechaVenta = fechaVenta;
        }


        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public double MontoTotal { get => _montoTotal; set => _montoTotal = value; }
        public DateTime FechaVenta { get => _fechaVenta; set => _fechaVenta = value; }

    }
}

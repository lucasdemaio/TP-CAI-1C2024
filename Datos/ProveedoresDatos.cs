using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProveedoresDatos
    {
        public Guid _id;
        public Guid _idCategoriaProducto;
        public string _nombre;
        public string _apellido;
        public DateTime _fechaAlta;
        public DateTime? _fechaBaja;
        public string _cuit;
        public string _email;
        public Guid _idUsuario;

        public ProveedoresDatos(Guid id, string nombre, DateTime fechaAlta, DateTime? fechaBaja ,string cuit, string email, string apellido, Guid idCategoriaProducto, Guid idUsuario)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _cuit = cuit;
            _fechaAlta = fechaAlta;
            _fechaBaja = fechaBaja;
            _idCategoriaProducto = idCategoriaProducto;                      
            _idUsuario = idUsuario;            
        }


        public Guid Id { get => _id; set => _id = value; }
        public Guid IdCategoriaProducto { get => _idCategoriaProducto; set => _idCategoriaProducto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public string CUIT { get => _cuit; set => _cuit = value; }
        public string Email { get => _email; set => _email = value; }        
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
       

        //public List<ProductoCategoria> Categorias { get; set; } // Lista de categorías de productos

        //public ProveedoresDatos()
        //{
        //    Categorias = new List<ProductoCategoria>();
        //}

        //public void AgregarCategoriaProducto(Guid idCategoria, string descripcion)
        //{
        //    Categorias.Add(new ProductoCategoria { Id = idCategoria, Descripcion = descripcion });
        //}
    }
}

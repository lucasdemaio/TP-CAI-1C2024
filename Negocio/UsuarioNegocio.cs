using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using static Datos.Usuario;
using static Datos.Json;
using static Datos.UsuarioDBLocal;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private Json dataManager = new Json();

        
        private UsuarioService usuarioService = new UsuarioService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public void agregarUsuario(int valorPerfil, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            UsuarioAlta altaUsuario = new UsuarioAlta(idAdministrador, valorPerfil, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            usuarioService.AgregarUsuario(altaUsuario);           
        }

        public void agregarUsuarioDBLocal(string nombre, string apellido, string mail, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, string nombreUsuario, int perfil, int dni, string contraseña, string estado)
        {
            UsuarioDBLocal usuarioDBlocal = new UsuarioDBLocal(nombre, apellido, mail, fechaAlta, fechaNacimiento, fechaBaja, nombreUsuario, perfil, dni, contraseña, estado);
            dataManager.GuardarUsuarioJson(usuarioDBlocal);
        }

        public List<UsuarioAlta> listarUsuarios(string idAdministrador)
        {
            return usuarioService.GetUsuarios(idAdministrador);
        }
    }
}


using Negocio;
using Presentacion;
using PresentacionLayer;
using System.Security.Cryptography;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frm = new FrmLogin();
            Application.Run(frm);

            UsuarioNegocio usuario = new UsuarioNegocio();

        }
    }
}
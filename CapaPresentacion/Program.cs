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

            //FrmMain frmMain = new FrmMain();
            //Application.Run(frmMain);

            UsuarioNegocio usuario = new UsuarioNegocio();

        }
    }
}
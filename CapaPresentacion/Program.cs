using PresentacionLayer;
using System.Security.Cryptography;

namespace CapaPresentacion
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

            //FrmBajaUsuario frm3 = new FrmBajaUsuario();
            //Application.Run(frm3);

            //FrmAltaUsuario frm4 = new FrmAltaUsuario();
            //Application.Run(frm4);

        }
    }
}
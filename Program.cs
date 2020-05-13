using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoCuentaByID
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new frmEstado("00005511Z"));
            Application.Run(new frmEstado());
            //Application.Run(new Form1("00005511Z", "",1));
            //Application.Run(new frmReportCristalEstadoMasivo());
        }
    }
}

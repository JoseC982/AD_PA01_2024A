//******************************************************
// Practica 07
// Jose Condor
// Fecha de realización: 11/06/2025
// Fecha de entrega: 18/06/2025
// Clase Form
// ***************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
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
            Application.Run(new FrmValidador());
        }
    }
}

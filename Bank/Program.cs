using Bank.NewFolder1;
using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            clsGlobal.CurrentUser = clsUser.Find(1);
            Application.Run(new frmMainLogin());
        }
    }
}

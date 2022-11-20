using laba8.Enums;
using laba8.Forms;
using laba8.Models;
using laba8.Services;
using laba8.Storage;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laba8
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            File<Administrator>.ReadFile("administrators");

            File<Computer>.ReadFile("computers");

            Application.Run(new AuthForm());
        }
    }
}

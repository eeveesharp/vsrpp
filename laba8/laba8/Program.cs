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

            //AdministratorStorage.AdministratorsList = new List<Administrator>()
            //{
            //    new Administrator(){ SecondName = "Chief", Password = "12345678", Age = 18, Role = "Chief" },
            //    new Administrator(){ SecondName = "Accountant", Password = "qwerty", Age = 35, Role = "Accountant" },
            //    new Administrator(){ SecondName = "SalesDepartment", Password = "asdfgh", Age = 54, Role = "SalesDepartment" }
            //};

            ComputerStorage.ComputersList = new List<Computer>()
            {
                new Notebook(){ CPU = "intel", GPU = "nvidia", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 2000, WorkHours = 12, TypeBattery = "LiOn", SetDate = new DateTime(2022,3,4)},
                new Notebook(){ CPU = "intel", GPU = "nvidia", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 2000, WorkHours = 8, TypeBattery = "LiOn", SetDate = new DateTime(2020,5,9), IsSell = true },
                new Desktop(){ CPU = "AMD", GPU = "nvidia", NumberOfCore = 16, NumberOfRAM = 16, PriceWithoutNds = 3500, TypeBody = "small", PowerBlock = 650, SetDate = new DateTime(2017,11,15), IsSell = true },
                new Notebook(){ CPU = "intel", GPU = "nvidia", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 2300, WorkHours = 10, TypeBattery = "LiOn", SetDate = new DateTime(2021,3,4)},
                new Desktop(){ CPU = "intel", GPU = "AMD", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 3000, TypeBody = "big", PowerBlock = 800, SetDate = new DateTime(2017,3,4)},
                new Notebook(){ CPU = "AMD", GPU = "nvidia", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 2000, WorkHours = 12, TypeBattery = "LiOn", SetDate = new DateTime(2017,7,4)},
                new Notebook(){ CPU = "AMD", GPU = "nvidia", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 2000, WorkHours = 11, TypeBattery = "LiOn", SetDate = new DateTime(2017,7,4)},
                new Notebook(){ CPU = "AMD", GPU = "nvidia", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 2000, WorkHours = 13, TypeBattery = "LiOn", SetDate = new DateTime(2017,7,4), IsSell = true },
                new Desktop(){ CPU = "intel", GPU = "AMD", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 3000, TypeBody = "big", PowerBlock = 500, SetDate = new DateTime(2017,3,4), IsSell = true },
                new Desktop(){ CPU = "intel", GPU = "AMD", NumberOfCore = 8, NumberOfRAM = 16, PriceWithoutNds = 3000, TypeBody = "big", PowerBlock = 800, SetDate = new DateTime(2017,3,4)},

            };

            //File<Administrator>.WriteFile(AdministratorStorage.AdministratorsList, "administrators");

            //File<Computer>.WriteFile(ComputerStorage.ComputersList, "computers");

            AdministratorStorage.AdministratorsList = File<Administrator>.ReadFile("administrators");

            //ComputerStorage.ComputersList = File<Computer>.ReadFile("computers");

            Application.Run(new AuthForm());
        }
    }
}

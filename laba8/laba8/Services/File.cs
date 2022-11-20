using laba8.Models;
using laba8.Storage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace laba8.Services
{
    public static class File<T>
    {
        public static void WriteFile(List<T> administrators, string name)
        {
            using (FileStream fs = new FileStream($"{name}.json", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(JsonConvert.SerializeObject(administrators));

                fs.Write(array, 0, array.Length);
            }
        }

        public static void ReadFile(string name)
        {
            string fileContent;

            using (FileStream fs = new FileStream($"{name}.json", FileMode.OpenOrCreate))
            {
                byte[] array = new byte[fs.Length];

                fs.Read(array, 0, array.Length);

                fileContent = System.Text.Encoding.Default.GetString(array);
            }

            if (name == "administrators")
            {
                AdministratorStorage.AdministratorsList = JsonConvert.DeserializeObject<List<Administrator>>(fileContent);
            }
            else
            {
                ComputerStorage.ComputersList = JsonConvert.DeserializeObject<List<Computer>>(fileContent);
            }

            
        }
    }
}

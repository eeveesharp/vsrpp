using laba8.Models;
using laba8.Storage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace laba8.Services
{
    public static class File
    {
        public static void WriteFile(List<Administrator> administrators)
        {
            using (FileStream fs = new FileStream($"administrators.json", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(JsonConvert.SerializeObject(administrators));

                fs.Write(array, 0, array.Length);
            }
        }

        public static void ReadFile()
        {
            string fileContent;

            using (FileStream fs = new FileStream($"administrators.json", FileMode.OpenOrCreate))
            {
                byte[] array = new byte[fs.Length];

                fs.Read(array, 0, array.Length);

                fileContent = System.Text.Encoding.Default.GetString(array);
            }

            AdministratorStorage.AdministratorsList = JsonConvert.DeserializeObject<List<Administrator>>(fileContent);
        }
    }
}

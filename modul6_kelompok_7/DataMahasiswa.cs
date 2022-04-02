using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_bluerecandy
{
    internal class DataMahasiswa_1302204090
    {

        // Mendapatkan path dari file json
        private string GetJsonPath => Path.GetFullPath(Directory.GetCurrentDirectory() + "/../../../1302204048.json");

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("/Users/basorif//modul6_kelompok_7/modul6_kelompok_7/jurnal6_1_1302204048.json");
            // Membuka file json
            var jsonFile = File.OpenText(GetJsonPath);

            // Deserialize json kedalam bentuk Dictionary
            Dictionary<string, dynamic> json = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonFile.ReadToEnd(), new JsonSerializerOptions()
            {
                WriteIndented = true,
            });

            // “Nama <nama depan + belakang> dengan nim <nim> dari fakultas <fakultas>”
            Console.WriteLine($"Nama {json["nama"]} dengan nim {json["nim"]} dari fakultas {json["fakultas"]}");
        }

    }
}

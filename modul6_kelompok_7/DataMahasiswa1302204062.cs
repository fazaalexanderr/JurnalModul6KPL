using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_kelompok_7
{
    public class DataMahasiswa1302204062
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Alamat address { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public List<Matkul> courses { get; set; }

        public DataMahasiswa1302204062() { }
        
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("/Users/Faza/praktikum_kpl/modul6_kelompok_7/modul6_kelompok_7/jurnal6_1_1302204062.json");

            DataMahasiswa1302204062 faza = JsonSerializer.Deserialize<DataMahasiswa1302204062>(jsonString);

            Console.WriteLine("Nama Depan: " + faza.firstName);
            Console.WriteLine("Nama Belakang: " + faza.lastName);
            Console.WriteLine("Jenis Kelamin: " + faza.gender);
            Console.WriteLine("Umur: " + faza.age);
            Console.WriteLine("Alamat: " + faza.address.streetAddress);
            Console.WriteLine("Kota: " + faza.address.city);
            Console.WriteLine("Provinsi: " + faza.address.state);
            int i = 0;
            foreach(Matkul course in faza.courses)
            {
                i++;
                Console.WriteLine("Kode Matkul " + i + ": " + course.code);
                Console.WriteLine("Nama Matkul " + i + ": " + course.name);
            }
        }
        public class Alamat
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public Alamat() { }
        }
        public class Matkul
        {
            public string code { get; set; }
            public string name { get; set; }

            public Matkul() { }
        }

    }
}

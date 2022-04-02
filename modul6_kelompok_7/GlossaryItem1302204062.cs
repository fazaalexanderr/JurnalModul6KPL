using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_kelompok_7
{
    public class GlossaryItem1302204062
    {
        public Glossary glossary { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("/Users/Faza/praktikum_kpl/modul6_kelompok_7/modul6_kelompok_7/jurnal6_3_1302204062.json");

            GlossaryItem1302204062 item = JsonSerializer.Deserialize<GlossaryItem1302204062>(jsonString);

            Console.WriteLine("ID: " + item.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("SortAs: " + item.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("GlossTerm: " + item.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("Acronym: " + item.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Abbrev: " + item.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("GlossDef: ");
            Console.WriteLine("para: " + item.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine("GlossSeeAlso: ");
            foreach (string gloss in item.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine(gloss);
            }
            Console.WriteLine("GlossSee: " + item.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
        public GlossaryItem1302204062() { }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GD GlossDiv { get; set; }
    }

    public class GD
    {
        public string title { get; set; }
        public GL GlossList { get; set; }
    }
    public class GL
    {
        public GE GlossEntry { get; set; }
    }
    public class GE
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }
    public class GDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }
}

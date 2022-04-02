using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_kelompok_7
{
    public class TeamMembers1302204062
    {
        public List<Member> members { get; set; }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("/Users/Faza/praktikum_kpl/modul6_kelompok_7/modul6_kelompok_7/jurnal6_2_1302204062.json");

            TeamMembers1302204062 team = JsonSerializer.Deserialize<TeamMembers1302204062>(jsonString);

            Console.WriteLine("Team member list:");
            int i = 0;
            foreach(Member anggota in team.members)
            {
                i++;
                Console.WriteLine(anggota.nim + " " + anggota.firstName + " " + anggota.lastName + " " + anggota.age + " " + anggota.gender);
            }
        }
        public TeamMembers1302204062() { }
    }

    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}

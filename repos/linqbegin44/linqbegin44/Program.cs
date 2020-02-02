using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqbegin44
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Team> teams = new List<Team>()
            //{
            //    new Team { Name = "Бавария", Country ="Германия" },
            //    new Team { Name = "Барселона", Country ="Испания" }
            //};
            //List<Player> players = new List<Player>()
            //{
            //    new Player {Name="Месси", Team="Барселона"},
            //    new Player {Name="Неймар", Team="Барселона"},
            //    new Player {Name="Роббен", Team="Бавария"}
            //};
            //var result = from player in players
            //             join team in teams on player.Team equals team.Name
            //             select new { name = player.Name, team = player.Team, country = team.Country };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.name + item.team + item.country);
            //}
            int k1 = 7;
            int k2 = 10;
            List<int> A = new List<int>()
            {
                2,4,6,7,11,111
            };
            List<int> B = new List<int>()
            {
                1,-2,20,99
            };
            var result = A.Join(B, ap => A, bp => B, (ap, bp) => new {ap > k1, bp < k2 };

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join
{
    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
    }
    class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
    class User
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
            {
                new Team { Name = "Бавария", Country ="Германия" },
                new Team { Name = "Барселона", Country ="Испания" }
            };
            List<Player> players = new List<Player>()
            {
                new Player {Name="Месси", Team="Барселона"},
                new Player {Name="Неймар", Team="Барселона"},
                new Player {Name="Роббен", Team="Бавария"}
            };
            var result = from player in players
                         join team in teams on player.Team equals team.Name
                         select new { name = player.Name, team = player.Team, country = team.Country };
            foreach (var item in result)
            {
                Console.WriteLine(item.name + item.team + item.country);
            }
            //List<User> users = new List<User>()
            //{
            //    new User { Name = "Tom", Age = 23 },
            //    new User { Name = "Sam", Age = 43 },
            //    new User { Name = "Bill", Age = 35 }
            //};
            //var result = users.All(item => item.Age > 20);           
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> player = new List<Player>();

            player.Add(new Player() { Name = "Kenn", Score = 100 });
            player.Add(new Player() { Name = "Aaron", Score = 3 });
            player.Add(new Player() { Name = "Paul", Score = 97 });
            player.Add(new Player() { Name = "Adam", Score = 98 });
            player.Add(new Player() { Name = "Matt", Score = 90 });
            player.Add(new Player() { Name = "Quency", Score = 90 });
            player.Add(new Player() { Name = "Nate", Score = 56 });
            player.Add(new Player() { Name = "Michelle", Score = 74 });
            player.Add(new Player() { Name = "Jay", Score = 10 });




            //1 Set up collection
            //int[] students = { 56, 78, 90, 97, 95, 86, 87, 44, 65, 47, 34 };

            //2 Set up the query
            IEnumerable<int> query = from s in player
                                        where s.Score > 85
                                        select s;

            //3 Iterate through the collection using query
            foreach(int Score in query)
            {
                Console.WriteLine(Score);
            }

            Console.ReadLine();
        }
    }

    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        //public Player(string name, int score)
        //{
        //    Name = name;
        //    Score = score;
        //}
    }
}

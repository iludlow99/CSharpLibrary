using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
    class Netflix
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public Netflix(string name, string genre, int rating)
        {
            Name = name;
            Genre = genre;
            Rating = rating;
        }

        public void GetShowInfo()
        {
            Console.WriteLine();
        }
    }
        
        
}

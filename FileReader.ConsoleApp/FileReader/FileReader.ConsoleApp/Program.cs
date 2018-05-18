using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\MyTest.txt";

            CustomFileReader cfr = new CustomFileReader();
            cfr.CreateFile(path);

            cfr.ReadFile(path);
            Console.ReadLine();
        }
    }
}

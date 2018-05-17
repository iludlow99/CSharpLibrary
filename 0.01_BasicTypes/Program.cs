using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._01_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            short sh = 32767;
            byte by = 255;
            string st = "Hello World";

            char c = 'i';
            

            //Declared
            bool isTired;
            //Initialized
            isTired = true;

            double doub = 7.80;
            float f = 8.75f;
            long l = 7500;

            int? n = null;

            if (isTired)
                Console.WriteLine("Yup, I'm tired.");


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}

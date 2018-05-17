using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut mattsDonut = new Donut();
            mattsDonut.Type = "Glazed";
            mattsDonut.HasCream = false;
            mattsDonut.Price = 10.99m;
            mattsDonut.Price = 200.89m;

            Console.WriteLine(mattsDonut.Type);
            mattsDonut.PrintDonutType();

            SpeechSynthesizer speak = new SpeechSynthesizer();
                speak.Speak("Why is Aaron here");

            Console.ReadLine();


        }
    }
}

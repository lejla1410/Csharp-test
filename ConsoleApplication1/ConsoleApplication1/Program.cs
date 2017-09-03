using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Losowosc
    {
        static int Randomowe( int min, int max)
        {
        Random rnd1 = new Random();
        int pierwsza = rnd1.Next(min, max);
        Console.WriteLine(" Podaj pierwszą liczbę:");
        pierwsza = Console.ReadLine();
        Random rnd2 = new Random();
        int druga = rnd2.Next(min, max);
        Console.WriteLine(" Podaj drugą liczbę:");
        druga= Console.ReadLine();
            return pierwsza + druga;

    }
    }
}

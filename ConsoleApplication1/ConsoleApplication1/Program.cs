using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Jak masz na imie?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Ile masz lat?");
            string wiek;
            wiek = Console.ReadLine();

            Console.WriteLine("Cześć " + name + " fajnie, że masz " + wiek + " lat");
            Console.ReadLine();
        }
    }
}

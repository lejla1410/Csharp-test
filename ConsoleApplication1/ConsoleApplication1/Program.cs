using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Losowosc
    {
        static void Main(string[] args)
        {
            int userInpMin = 0;
            int userInpMax = 0;
            Input("Type min number: ", ref userInpMin);
            Input("Type max number: ", ref userInpMax);
            AddRandomNumbers(userInpMin, userInpMax);

            Console.ReadLine();
        }

        static void AddRandomNumbers(int min, int max)
        {
            Random random = new Random();
            int num1 = random.Next(min, max);
            int num2 = random.Next(min, max);
            Console.WriteLine($"First random number: {num1}. Second random number: {num2}");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        static void Input(string description, ref int inputVariable)
        {
            Console.Write(description);
            inputVariable = Convert.ToInt32(Console.ReadLine());
        }

    }
    }

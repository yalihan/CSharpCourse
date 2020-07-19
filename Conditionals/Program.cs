using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 5;
            if (number == 5)
            {
                Console.WriteLine("Number is 5", number);
            }
            else if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 5 or 10");
            }
            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            var number2 = 10;
            switch (number)
            {
                case 5:
                    Console.WriteLine("Number2 is 5");
                    break;
                case 10:
                    Console.WriteLine("Number2 is 10");
                    break;
                default:
                    Console.WriteLine("Number2 is not 5 or 10");
                    break;
            }

            var number3 = 98;
            if (number3 >= 10 && number3 < 100)
            {
                Console.WriteLine("Number3 is between 10 and 100");
            }else if(number3>=100 && number3 <= 200)
            {
                Console.WriteLine("Number3 is between 100 and 200");
            }
            else
            {
                Console.WriteLine("Number is bigger than 200 or less than 10");
            }
            Console.ReadLine();
        }
    }
}

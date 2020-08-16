using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(4, 5));

            Func<int> getRandomNumber1 = delegate()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber1());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());
        
            Console.ReadLine();
        }

        private static int Topla(int number1 , int number2)
        {
            return number1 + number2;
        }
    }
}

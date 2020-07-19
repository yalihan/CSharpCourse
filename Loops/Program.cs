using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();
            //isPrimeNumber(13);

            Console.ReadLine();
        }
        
        private static bool isPrimeNumber(int number)
        {
            for(int i=2; i<number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Asal değildir.");
                    return false;
                }
            }
            Console.WriteLine("Asaldır");
            return true;
        }
        private static void ForEachLoop()
        {
            string[] family = { "Alihan", "Merve", "Omer", "Hamza" };
            foreach (var familyMember in family)
            {
                Console.WriteLine(familyMember);
            }
        }
        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number > 11);
        }
        private static void WhileLoop()
        {
            int number = 100;
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
        private static void ForLoop()
        {
            for (int i = 0; i < 10; i += 2)
            {
                Console.Write(i + "   ");
            }
        }
    }
}

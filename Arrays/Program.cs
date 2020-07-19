using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = { "Alihan", "Merve", "Omer", "Hamza" };
            //students[4] = "dort";
            //foreach (var student in students)
            //{
            //    Console.Write("\n" + student + " ");
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Isparta"},
                {"Antalya","Adana","Mersin"},
                {"Giresun","Trabzon","Rize"},
                {"İzmir","Muğla","Manisa"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.Write(regions[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

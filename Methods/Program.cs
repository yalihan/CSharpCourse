using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*out; methodun içerisinde, gönderdiğimiz değeri set etmek zorunda bırakır ve set edilmiş değere göre çalışır.
            o yüzden, methodun parametrisine girilmeden önce verilen değerin hiç bir önemi yoktur.*/

            /*ref; methodun içerisinde, gönderdiğimiz değeri set etmek zorunda değiliz. Eğer, methodun parametresine girilmeden önce
             verilen bir değer varsa ve methodun içerisinde ayrı olarak set edilmemişse ona göre çalışır. Method içerisinde set edilmişse
            methodun içerisindeki değerine göre çalışır.*/

            int a1 = 30;
            int b1 = 40;
            int c1 = 50;
            var result = add(out a1, ref b1,c1);
            var resultParams = add(1, 2, 3, 4, 5);
            Console.WriteLine("Result : "+result);
            Console.WriteLine("a1 : " + a1);
            Console.WriteLine("b1 : " + b1);
            Console.WriteLine("c1 : " + c1);
            Console.WriteLine("ResultParams : " + resultParams);
            Console.ReadLine();
        }
        static int add(out int a2,ref int b2,int c2)
        {
            a2 = 30;
            b2 = 35;
            c2 = 45;
            return a2 + b2 + c2;
        }
        static int add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}

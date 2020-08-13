using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //NormalInstance();
            //Reflection();
            //MethodInfoInvoke();
            DetailsOfReflection();

            Console.ReadLine();
        }
        private static void DetailsOfReflection()
        {
            var tip = typeof(DortIslem);
            var instance = Activator.CreateInstance(tip, 3, 9);
            var metodlar = tip.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod Adi : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("\tParametre Adi : {0}", parameterInfo.Name);
                }
                foreach (var attributeInfo in info.GetCustomAttributes())
                {
                    Console.WriteLine("\t\tAttribute Adi : {0}",attributeInfo.GetType().Name);
                }
            }
        }
        private static void MethodInfoInvoke()
        {
            var tip = typeof(DortIslem);
            
            var instance = Activator.CreateInstance(tip,8,9);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));
        }
        private static void Reflection()
        {
            var tip = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem) Activator.CreateInstance(tip,1,2);
            Console.WriteLine("Cons Toplam : " + dortIslem.Topla2());
            Console.WriteLine("Cons Carpim : " + dortIslem.Carp2());
            Console.WriteLine("Param Toplam : " + dortIslem.Topla(2, 3));
            Console.WriteLine("Param Carpim : " + dortIslem.Carp(3, 4));
        }

        private static void NormalInstance()
        {
            DortIslem dortIslem = new DortIslem(1, 2);
            Console.WriteLine("Cons Toplam : " + dortIslem.Topla2());
            Console.WriteLine("Cons Carpim : " + dortIslem.Carp2());
            Console.WriteLine("Param Toplam : " + dortIslem.Topla(2, 3));
            Console.WriteLine("Param Carpim : " + dortIslem.Carp(3, 4));
        }
    }
    public class DortIslem
    {
        private int _sayi1, _sayi2;
        public DortIslem()
        {

        }
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}

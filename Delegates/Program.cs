using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1 , int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Delegate Text");

            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            Console.WriteLine(myDelegate3(3, 4));


            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Message is sended!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful !");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine("Send Message => " + message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine("Show Alert => " + alert);
        }
    }
    public class Matematik
    {
        public int Topla(int number1 , int number2)
        {
            return number1 + number2;
        }
        public int Carp(int number1 , int number2)
        {
            return number1 * number2;
        }
    }
}

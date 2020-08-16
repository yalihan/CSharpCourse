using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "Telefon";
            gsm.StockControlEvent += Gsm_StockControlEvent;
            

            for (int i=0; i<10; i++)
            {
                harddisk.Sell(10);
                ControllingException(()=>gsm.Sell(10));
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            throw new StockException("Stoğu kontrol et");
        }
        private static void ControllingException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch(StockException stockException)
            {
                Console.WriteLine(stockException.Message);
            }
        }
    }
}

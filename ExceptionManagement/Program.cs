using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionWithoutCatchParameter();
            //ExceptionWithCatchParameter();
            //WorkingOwnExceptionClass();
            CatchingErrorWithActionDelegation(()=>FindingRecord());
            Console.ReadLine();


        }
        private static void CatchingErrorWithActionDelegation(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine("RecordNotFoundException Calisti.\nHata Mesaji --> " + exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("IndexOutOfRangeException Calisti.\nHata Mesaji --> " + exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Calisti.\nHata Mesaji --> " + exception.Message);
            }
        }
        private static void WorkingOwnExceptionClass()
        {
            try
            {
                FindingRecord();
            }
            catch (RecordNotFoundException recordNotFoundException)
            {
                Console.WriteLine(recordNotFoundException.Message);
            }
            //FindingRecord();
        }
        private static void FindingRecord()
        {
            List<string> students = new List<string> { "Alihan", "Merve", "Omer" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }
        private static void ExceptionWithCatchParameter()
        {
            try
            {
                string[] family = new string[3] { "Alihan", "Merve", "Omer" };
                //family[3] = "Hamza";

                //int a = 0;
                //int b = 5 / a;



            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("DivideByZeroException Calisti.\nHata Mesaji --> " + exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("IndexOutOfRangeException Calisti.\nHata Mesaji --> " + exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Calisti.\nHata Mesaji --> " + exception.Message);
            }
        }
        private static void ExceptionWithoutCatchParameter()
        {
            try
            {
                string[] family = new string[3] { "Alihan", "Merve", "Omer" };
                family[3] = "Hamza";
            }
            catch
            {
                Console.WriteLine("Haddini Aşma! :)");
            }
        }
    }
}

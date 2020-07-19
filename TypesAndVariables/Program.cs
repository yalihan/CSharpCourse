using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool condition = true;
            char character = 'A';
            byte byteNumber = 255;
            short shortNumber = 32767;
            int integerNumber = 2147483647;
            long longNumber = 9223372036854775807;
            double doubleNumber = 1.754635153;
            decimal decimalNumber = 1.74534841684315843m;
            String day = "Sunday";
            if (Days.Sunday.Equals(day)) {
                Console.WriteLine("Dogru");
            }else {
                Console.WriteLine("Yanlis");
            }
            Console.WriteLine("Byte    Number (1Byte  =   8bit) (2 ^ 8)   : {0}" +
                            "\nShort   Number (2Byte  =  16Bit) (2 ^ 16)  : {1}" +
                            "\nInteger Number (4Byte  =  32Bit) (2 ^ 32)  : {2}" +
                            "\nLong    Number (8Byte  =  64Bit) (2 ^ 64)  : {3}" +
                            "\nDouble  Number (8Byte  =  64Bit) (2 ^ 64)  : {4}" +
                            "\nDecimal Number (16Byte = 128Bit) (2 ^ 128) : {5}" +
                            "\nBoolean Condition..........................: {6}" +
                            "\nChar    Character..........................: {7}" +
                            "\nInteger value of Character.................: {8}" +
                            "\nEnum     Days..............................: {9}" +
                            "\nIndex of {9}............................: {10}"
                            ,byteNumber,shortNumber,integerNumber,longNumber,doubleNumber,decimalNumber
                            ,condition,character,(int)character,Days.Monday,(int)Days.Monday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday=45,Saturday,Sunday
    }
}

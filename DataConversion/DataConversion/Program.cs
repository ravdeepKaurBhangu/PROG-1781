using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 9;
            int y = 23;
            Console.WriteLine("x is "+x);
            Console.WriteLine("y is " +y);

            y = x;
           // x = y;
            //Console.WriteLine("Updated value of y is "+y);

            x = (byte)y;
            //Console.WriteLine("Updated value of x is " + x);

            double num1 = 98.789;
            int num2;
            num2 = (int)num1;
            Console.WriteLine("int value is "+num2);

            /*   char c1 = 't';
               string s1;

               c1 = (char)s1;
               //s1 = (string)c1;
               Console.WriteLine(s1);
               */
           decimal amountDecimal = 67.67863767M;
            decimal resultDecimal;
         resultDecimal = decimal.Round(amountDecimal, 4);
            Console.WriteLine(resultDecimal);
// uploaded on github
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value");
            String value=Console.ReadLine();
            int v = int.Parse(value);

            if(v%2==0)
            {
                Console.WriteLine("Even number ");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            Console.WriteLine("YOu have entered "+v);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableOperations
{
    class Program
    {
        public int x = 90;
        static void Main(string[] args)
        {
            //  Console.WriteLine(x);
            //    Console.WriteLine("He said \"I like C# \" ");

            String marks1 = "56";
            String marks2 = "34";
            String abc;
            int m1,m2;

            m1=int.Parse(marks1);
            m2 = int.Parse(marks2);
            Console.WriteLine(marks1 + marks2);
            Console.WriteLine(m1+m2);


           abc=m1.ToString();

        }
    }
}

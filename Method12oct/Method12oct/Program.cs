using System;

namespace Method12oct
{
    class Program
    {
        double pi = 3.14;
    /*    static double isLarger(double num1,double num2)
        {
            double r;
            if(num1>num2)
            {
                r = num1;
            }
            else
            {
                r = num2;
            }
            return r;
        }*/
        static void area(int s)
        {
            int a = s*s;
            Console.WriteLine("Area of square is "+a);
        }
        static void area(double radius)
        {
            
            double a = pi * radius * radius;
            Console.WriteLine("Area of circle is " + a);
        }
        static void area(double l,double b)
        {

            double a = l*b;
            Console.WriteLine("Area of rectangle is " + a);
        }
        static void Main(string[] args)
        {
            // double l=isLarger(89.5,12.56);
            //Console.WriteLine(l+" is larger");

            Console.WriteLine("Please choose an appropriate option:");
            Console.WriteLine("a:Circle");
            Console.WriteLine("b:Square");
            Console.WriteLine("c:Rectangle");
            string input = Console.ReadLine();
            if(input=="b")
            {

                Console.WriteLine("Enter side of Square");
                String s = Console.ReadLine();
                int s = int.Parse(s);
                area(s);
            }
            else if(input=="a")
            {
                Console.WriteLine("Enter Radius of circle");
                String r = Console.ReadLine();
                double radius = double.Parse(r);
                area(r);
            }
            else if(input=="c")
            {
                Console.WriteLine("Enter length and Breadth of Rectangle");
                String l = Console.ReadLine();
                String b = Console.ReadLine();
                double len = double.Parse(l);
                double breadth = double.Parse(b);
                area(len,breadth);
            }
        }
    }
}

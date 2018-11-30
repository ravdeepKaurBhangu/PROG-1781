using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingClassesPractice
{
    public class Conestoga
    {
        public string course1, course2, course3, course4;
        public Conestoga(string c1,string c2,string c3,string c4)
        {
            course1 = c1;
            course2 = c2;
            course3 = c3;
            course4 = c4;
        }
        public Conestoga()
        {
            Console.WriteLine("Students are having test fever");
        }
        public void courses()
        {
            Console.WriteLine(course1+" "+course2+" "+course3+" "+course4);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conestoga student = new Conestoga("ITD","CM","SCOM","EET");

            student.courses();

            Conestoga nalayakbache = new Conestoga();
        }
    }
}

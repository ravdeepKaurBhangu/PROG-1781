using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingClasses
{
    class Class1
    {
        public Class1(int x)
        {
            MessageBox.Show("Constructor Called "+x.ToString());
        }
        public void display(int y)
        {
            MessageBox.Show("Method in a class is called");
        }
        public void display(double y)
        {
            MessageBox.Show("Method in a class is called "+y);
        }
    }
}

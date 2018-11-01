using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void withdraw(double bal,double deb)
        {
            double totalbal = bal - deb;
            Console.WriteLine("Balance after deduction is "+totalbal);
        }
        static void deposit(double bal, double dep)
        {
            double totalbal = bal + dep;
            Console.WriteLine("Balance after credit is " + totalbal);
        }
        static void balanceStatement(String name,double balance)
        {
            Console.WriteLine("Name :"+name+" Balance :"+balance);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name and bank balance");
            String n = Console.ReadLine();
            String bal = Console.ReadLine();
            double balance = double.Parse(bal);
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1: Withdraw");
            Console.WriteLine("2: Deposit");
            Console.WriteLine("3: Balance Enquiry");
            String option = Console.ReadLine();
            if(option=="1")
            {
                Console.WriteLine("Enter amount to be withdrawn");
                String debit = Console.ReadLine();
                double deb = double.Parse(debit);
                withdraw(balance,deb);
            }
            else if (option == "2")
            {
                Console.WriteLine("Enter amount to be deposited");
                String depos = Console.ReadLine();
                double dep = double.Parse(depos);
                deposit(balance, dep);
            }
            else if(option == "3")
            {
                balanceStatement(n,balance);
            }

        }
    }
}

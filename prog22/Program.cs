using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Savings Account ----");
            Savings s = new Savings();
            s.GetAccountData();
            s.Deposit(500);
            s.Withdraw(300);
            s.CheckBalance();

            Console.WriteLine("\n---- Current Account ----");
            Current c = new Current();
            c.GetAccountData();
            c.Deposit(1000);
            c.Withdraw(1500);
            c.CheckBalance();

            Console.ReadLine();
        }
    }
}

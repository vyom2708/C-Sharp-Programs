using System;
using System.Security.Principal;

public class Savings : account
{
    public double interestRate = 5.0;

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Savings: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }
}
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("段誉", 100);
            account.Deposit(1000);
            account.Withdraw(2000);
            account.Deposit(3000);
            account.Withdraw(4000);
            account.Withdraw(1000);
            account.ComputeInterest();
        }
    }
}

// See https://aka.ms/new-console-template for more information
using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ken", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}. ");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox");

            Console.WriteLine(account.GetAccountHistory());

            //account.makeDeposits(-300, DateTime.Now, "yetss");
        }
    }
}
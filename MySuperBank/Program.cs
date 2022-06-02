// See https://aka.ms/new-console-template for more information
using BankingStuff;
using System;


namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("Ken", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}. ");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock"); ;
            account.MakeWithdrawal(50, DateTime.Now, "Xbox");
            account.MakeWithdrawal(5, DateTime.Now, "Coffe");
            account.MakeWithdrawal(130, DateTime.Now, "Diet Coke");
            account.MakeWithdrawal(10, DateTime.Now, "Tea");
            account.MakeWithdrawal(70, DateTime.Now, "Plants");

            Console.WriteLine(account.GetAccountHistory());

            //account.makeDeposits(-300, DateTime.Now, "yetss");
        }
    }
}
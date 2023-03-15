using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Bryon Carlin", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with a starting balance of ${account.Balance}.");


            account.MakeWithdrawal(120, DateTime.Now, "Amazon.com");
            Console.WriteLine("Current balance is now $" + account.Balance + ".");

            
            account.MakeDeposit(500, DateTime.Now, "Rent money");
            Console.WriteLine("Current balance after deposit is now $" + account.Balance + ".");




            Console.WriteLine(account.GetAccountHistory());

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Can't create account with a negative balance.");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
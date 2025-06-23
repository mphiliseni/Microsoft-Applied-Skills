using System;
using Banking;

namespace Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO Task 1.2
            BankAccount account = new BankAccount
            {
                AccountNumber = "123456789",
                Balance = 1000.23m
            };
            Console.WriteLine($"Account Number: {account.AccountNumber} Balance: {account.Balance:C}");
            //END TODO Task 1.2
        }
    }
}
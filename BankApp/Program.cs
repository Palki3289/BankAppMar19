using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.AccountNumber = 12345;
            account.Balance = 10000000000000;
        }
    }
}

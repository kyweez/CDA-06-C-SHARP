using System;

namespace BANK_ACCOUNT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\x1b[36mCreating 2 bank accounts :");
            Console.WriteLine("==========================\x1b[0m");
            Console.WriteLine("\x1b[35mBankAccount account_aurel = new BankAccount(\"001\", \"Aurel\");");
            Console.WriteLine("BankAccount account_mike = new BankAccount(\"002\", \"Mike\");\x1b[0m");
            BankAccount account_aurel = new BankAccount("001", "Aurel");
            BankAccount account_mike = new BankAccount("002", "Mike");
            Console.WriteLine("\n---------------------------------------------------------------------\n");

            Console.WriteLine("\x1b[36mSetters testing :");
            Console.WriteLine("=================\x1b[0m");
            account_aurel.Balance = 20000.123f;
            account_aurel.AuthorizedOverdraft = 700; 
        }
    }
}

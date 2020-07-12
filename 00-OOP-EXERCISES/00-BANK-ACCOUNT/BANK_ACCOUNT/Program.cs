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
            Console.WriteLine("\x1b[35maccount_aurel.Balance = 20000f;");
            Console.WriteLine("account_aurel.AuthorizedOverdraft = 700f;\x1b[0m");
            account_aurel.Balance = 20000f;
            account_aurel.AuthorizedOverdraft = 700f;
            Console.WriteLine("\n---------------------------------------------------------------------\n");

            Console.WriteLine("\x1b[36mSetters testing (with errors) :");
            Console.WriteLine("===============================\x1b[0m");
            Console.WriteLine("\x1b[35maccount_mike.Balance = -20000f;\x1b[31m");
            account_mike.Balance = -20000f;
            Console.WriteLine("\x1b[35maccount_mike.AuthorizedOverdraft = -700f;\x1b[31m");
            account_mike.AuthorizedOverdraft = -700f;
            Console.WriteLine("\x1b[0m\n---------------------------------------------------------------------\n");
        }
    }
}

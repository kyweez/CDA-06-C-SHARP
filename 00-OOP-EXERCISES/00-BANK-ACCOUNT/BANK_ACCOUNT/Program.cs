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
            Console.WriteLine("\n\x1b[42mVALID TESTS \x1b[0m");
            Console.WriteLine("---------------------------------------------------------------------\n");

            Console.WriteLine("\x1b[36mSetters testing :");
            Console.WriteLine("=================\x1b[0m");
            Console.WriteLine("\x1b[35maccount_aurel.Balance = 20000f;");
            Console.WriteLine("account_aurel.AuthorizedOverdraft = 700f;\x1b[0m");
            account_aurel.Balance = 20000f;
            account_aurel.AuthorizedOverdraft = 700f;
            Console.WriteLine("\n\x1b[42mVALID TESTS \x1b[0m");
            Console.WriteLine("---------------------------------------------------------------------\n");

            Console.WriteLine("\x1b[36mSetters testing (with errors) :");
            Console.WriteLine("===============================\x1b[0m");
            Console.WriteLine("\x1b[35m\naccount_mike.Balance = -20000f;\x1b[31m");
            account_mike.Balance = -20000f;
            Console.WriteLine("\x1b[35m\naccount_mike.AuthorizedOverdraft = -700f;\x1b[31m");
            account_mike.AuthorizedOverdraft = -700f;
            Console.WriteLine("\x1b[35m\naccount_mike.AuthorizedOverdraft = 70000f;");
            account_mike.AuthorizedOverdraft = 70000f;
            Console.WriteLine("\x1b[35m\naccount_mike.Balance = -20000f;\x1b[31m");
            account_mike.Balance = -20000f;
            Console.WriteLine("\x1b[35m\naccount_mike.AuthorizedOverdraft = 700f;\x1b[31m");
            account_mike.AuthorizedOverdraft = 700f;
            Console.WriteLine("\n\x1b[0m\x1b[42mVALID TESTS \x1b[0m");
            Console.WriteLine("---------------------------------------------------------------------\n");

            Console.WriteLine("\x1b[36mPrint information :");
            Console.WriteLine("===================\x1b[0m");
            Console.WriteLine("\x1b[35maccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\n\x1b[35maccount_mike.PrintInformation();\x1b[32m");
            account_mike.PrintInformation();
            Console.WriteLine("\n\x1b[0m\x1b[42mVALID TESTS \x1b[0m");
            Console.WriteLine("---------------------------------------------------------------------\n");

            Console.WriteLine("\x1b[36mCredit test :");
            Console.WriteLine("=============\x1b[0m");
            Console.WriteLine("\x1b[44mError case 1 : value < 0 : \x1b[0m");
            Console.WriteLine("\x1b[35mfloat amount = -12f;");
            Console.WriteLine("if (account_aurel.Credit(amount))");
            Console.WriteLine("    Console.WriteLine(\"Account has been credited\");");
            Console.WriteLine("else");
            Console.WriteLine("    Console.WriteLine(\"Can't credit with this amount\");\x1b[32m");
            float amount = -12f;
            if (account_aurel.Credit(amount))
                Console.WriteLine("Account has been credited");
            else
                Console.WriteLine("Can't credit with this amount");
            Console.WriteLine("\x1b[0m\n\x1b[44mError case 2 : overflow : \x1b[0m");
            Console.WriteLine("\x1b[35maccount_aurel.Balance = 3.4f * (float)Math.Pow(10, 38);");
            account_aurel.Balance = 3.4f * (float)Math.Pow(10, 38);
            Console.WriteLine("\x1b[35maccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\x1b[35mamount = 3.4f * (float)Math.Pow(10, 38);");
            Console.WriteLine("if (account_aurel.Credit(amount))");
            Console.WriteLine("    Console.WriteLine(\"Account has been credited\");");
            Console.WriteLine("else");
            Console.WriteLine("    Console.WriteLine(\"Can't credit with this amount\");\x1b[32m");
            amount = 3.4f * (float)Math.Pow(10, 38);
            if (account_aurel.Credit(amount))
                Console.WriteLine("Account has been credited");
            else
                Console.WriteLine("Can't credit with this amount");
            Console.WriteLine("\x1b[0m\n\x1b[44mValid test case 3 : \x1b[0m");
            Console.WriteLine("\x1b[35maccount_aurel.Balance = 20000f;");
            account_aurel.Balance = 20000f;
            Console.WriteLine("\x1b[35maccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\x1b[35m\namount = 30000f;");
            Console.WriteLine("if (account_aurel.Credit(amount))");
            Console.WriteLine("    Console.WriteLine(\"Account has been credited\");");
            Console.WriteLine("else");
            Console.WriteLine("    Console.WriteLine(\"Can't credit with this amount\");\x1b[32m");
            amount = 30000f;
            if (account_aurel.Credit(amount))
                Console.WriteLine("Account has been credited");
            else
                Console.WriteLine("Can't credit with this amount");
            Console.WriteLine("\x1b[35m\naccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\n\x1b[0m\x1b[42mVALID TESTS \x1b[0m");
            Console.WriteLine("---------------------------------------------------------------------\n");

            Console.WriteLine("\x1b[36mDebit test :");
            Console.WriteLine("=============\x1b[0m");
            Console.WriteLine("\x1b[44mError case 1 : value < 0 : \x1b[0m");
            Console.WriteLine("\x1b[35mfloat amount2 = -12f;");
            Console.WriteLine("if (account_aurel.Debit(amount2))");
            Console.WriteLine("    Console.WriteLine(\"Account has been debited\");");
            Console.WriteLine("else");
            Console.WriteLine("    Console.WriteLine(\"Can't debit with this amount\");\x1b[32m");
            float amount2 = -12f;
            if (account_aurel.Debit(amount2))
                Console.WriteLine("Account has been debited");
            else
                Console.WriteLine("Can't debit with this amount");
            Console.WriteLine("\x1b[0m\n\x1b[44mError case 2 :underflow : \x1b[0m");
            Console.WriteLine("\x1b[35maccount_aurel.Balance = -3.4f * (float)Math.Pow(10, 38);");
            account_aurel.AuthorizedOverdraft = float.MaxValue;
            account_aurel.Balance = float.MinValue;
            Console.WriteLine("\x1b[35maccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\x1b[35\nmamount2 = -3.4f * (float)Math.Pow(10, 38);");
            Console.WriteLine("if (account_aurel.Debit(amount2))");
            Console.WriteLine("    Console.WriteLine(\"Account has been debited\");");
            Console.WriteLine("else");
            Console.WriteLine("    Console.WriteLine(\"Can't debit with this amount\");\x1b[32m");
            amount2 = -3.4f * (float)Math.Pow(10, 38);
            if (account_aurel.Debit(amount2))
                Console.WriteLine("Account has been debited");
            else
                Console.WriteLine("Can't debit with this amount");
            Console.WriteLine("\x1b[0m\n\x1b[44mValid test case 3 : \x1b[0m");
            Console.WriteLine("\x1b[35maccount_aurel.Balance = 20000f;");
            account_aurel.Balance = 20000f;
            account_aurel.AuthorizedOverdraft = 20000f;
            Console.WriteLine("\x1b[35maccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\x1b[35m\namount = 30000f;");
            Console.WriteLine("if (account_aurel.Debit(amount))");
            Console.WriteLine("    Console.WriteLine(\"Account has been debited\");");
            Console.WriteLine("else");
            Console.WriteLine("    Console.WriteLine(\"Can't debit with this amount\");\x1b[32m");
            amount = 30000f;
            if (account_aurel.Debit(amount))
                Console.WriteLine("Account has been debited");
            else
                Console.WriteLine("Can't debit with this amount");
            Console.WriteLine("\x1b[35m\naccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\n\x1b[0m\x1b[42mVALID TESTS \x1b[0m");
            Console.WriteLine("\x1b[0m\n\x1b[44mValid test case 4 : \x1b[0m");
            Console.WriteLine("\x1b[35maccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\x1b[35m\namount = 500f;");
            Console.WriteLine("if (account_aurel.Debit(amount))");
            Console.WriteLine("    Console.WriteLine(\"Account has been debited\");");
            Console.WriteLine("else");
            Console.WriteLine("    Console.WriteLine(\"Can't debit with this amount\");\x1b[32m");
            amount = 500f;
            if (account_aurel.Debit(amount))
                Console.WriteLine("Account has been debited");
            else
                Console.WriteLine("Can't debit with this amount");
            Console.WriteLine("\x1b[35m\naccount_aurel.PrintInformation();\x1b[32m");
            account_aurel.PrintInformation();
            Console.WriteLine("\n\x1b[0m\x1b[42mVALID TESTS \x1b[0m");
            Console.WriteLine("---------------------------------------------------------------------\n");
        }
    }
}
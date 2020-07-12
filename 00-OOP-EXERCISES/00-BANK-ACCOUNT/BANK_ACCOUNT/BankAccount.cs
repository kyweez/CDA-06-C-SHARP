using System;

namespace BANK_ACCOUNT
{
    class BankAccount
    {
        //===================== ATTRIBUTES =====================//
        private string accountNumber;
        private string owner;
        private float balance;
        private float authorizedOverdraft;

        //===================== CONSTRUCTORS ====================//
        /// <summary>
        /// BankAccount constructor
        /// </summary>
        /// <param name="_accountNumber">accountNumber value</param>
        /// <param name="_owner">owner value</param>
        public BankAccount(string _accountNumber, string _owner)
        {
            accountNumber = _accountNumber;
            owner = _owner;
            balance = 0f;
            authorizedOverdraft = 0f;
        }

        //================== GETTERS & SETTERS =================//
        /// <summary>
        /// acccountNumber getter
        /// </summary>
        public string AccountNumber => accountNumber;

        /// <summary>
        /// owner getter
        /// </summary>
        public string Owner => owner;

        /// <summary>
        /// balance getter & setter
        /// </summary>
        public float Balance
        {
            get => balance;
            set
            {
                if (value < authorizedOverdraft)
                {
                    Console.WriteLine("Can't set a value under the authorized overdraft");
                    return;
                }
                balance = value;
            }
        }

        /// <summary>
        /// authorizedOverdraft getter & setter
        /// </summary>
        public float AuthorizedOverdraft
        {
            get => authorizedOverdraft;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The authorized overdraft must be positive");
                    return;
                }
                if (value > balance)
                {
                    Console.WriteLine("Can't set an authorized overdraft");
                    return;
                }
                authorizedOverdraft = (value * -1);
            }
        }

        //======================= METHODS ======================//
        /// <summary>
        /// This method print all the information (fields) about the object
        /// </summary>
        public void PrintInformation()
        {
            Console.WriteLine(accountNumber);
            Console.WriteLine(owner);
            Console.WriteLine(balance);
            Console.WriteLine(authorizedOverdraft);
        }

        /// <summary>
        /// This method add (if possible) the given amount on the current bank account
        /// </summary>
        /// <param name="_amount"></param>
        /// <returns>bool</returns>
        public bool Credit(float _amount)
        {
            if (_amount < 0)
                return false;
            if (float.MaxValue - balance < _amount)
                return false;
            balance += _amount;
            return true;
        }

        /// <summary>
        /// This method substitute (if possible) the given amount on the current bank account
        /// </summary>
        /// <param name="_amount"></param>
        /// <returns>bool</returns>
        public bool Debit(float _amount)
        {

            if (float.MinValue + _amount < balance)
                return false;
            if (balance - _amount < authorizedOverdraft)
                return false;
            balance -= _amount;
            return true;
        }

        /// <summary>
        /// This method transfer (if possible) the given amount of monney on the given bamk account
        /// </summary>
        /// <param name="_account"></param>
        /// <param name="_amount"></param>
        /// <returns>bool</returns>
        public bool Transfer(BankAccount _account, float _amount)
        {
            float _accountBalance = _account.Balance;
            if (_amount <= 0)
                return false;
            if (float.MaxValue - _accountBalance < _amount)
                return false;
            if (float.MinValue + _amount < balance)
                return false;
            if (balance - _amount < authorizedOverdraft)
                return false;
            _account.Credit(_amount);
            balance -= _amount;
            return true;
        }

        /// <summary>
        /// This method returns a boolean
        /// If the current balance is higher than the given account balance : returns true
        /// Else return false
        /// </summary>
        /// <param name="_account"></param>
        /// <returns>bool</returns>
        public bool thisBalanceIsHigher(BankAccount _account)
        {
            return (balance > _account.Balance);
        }
    }
}
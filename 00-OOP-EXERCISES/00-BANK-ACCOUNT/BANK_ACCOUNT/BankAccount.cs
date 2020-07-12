using System;
using System.Collections.Generic;
using System.Text;

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
            set => balance = value;
        }

        /// <summary>
        /// authorizedOverdraft getter & setter
        /// </summary>
        public float AuthorizedOverdraft
        {
            get => authorizedOverdraft;
            set => authorizedOverdraft = value;
        }

        //======================= METHODS ======================//
        public void PrintInformation()
        {
            Console.WriteLine(accountNumber);
            Console.WriteLine(owner);
            Console.WriteLine(balance);
            Console.WriteLine(authorizedOverdraft);
        }

        public bool Credit(float _amount)
        {
            if (_amount < 0)
                return false;
            if (float.MaxValue - balance < _amount)
                return false;
            balance += _amount;
            return true;
        }

        public bool Debit(float _amount)
        {

            if (float.MinValue + _amount < balance)
                return false;
            if (balance - _amount < authorizedOverdraft)
                return false;
            balance -= _amount;
            return true;
        }

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

        public bool thisBalanceIsHigher(BankAccount _account)
        {
            return (balance > _account.Balance);
        }
    }
}

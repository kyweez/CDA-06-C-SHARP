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
        public string AccountNumber { get; }

        /// <summary>
        /// owner getter
        /// </summary>
        public string Owner { get; }

        /// <summary>
        /// balance getter and setter
        /// </summary>
        public string Balance { get; set; }

        /// <summary>
        /// authorizedOverdraft getter and setter
        /// </summary>
        public string AuthorizedOverdraft { get; set; }

        //======================= METHODS ======================//
        public void PrintInformation()
        {

        }

        public void Credit(float _string)
        {

        }

        public bool Debit(float _amount)
        {
            return true;
        }

        public bool Transfer(BankAccount _account, float _amount)
        {
            return true;
        }

        public bool balanceIsHigher(BankAccount _account)
        {
            return true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
     public enum AccountType
    {
        Checking,
        Savings,
        CD,
        Loan
    }
    /// <summary>
    /// Account that represents 
    /// Bank account. Here you can withdraw or deposit your money.
    /// </summary>
    public class Account
    {       

        #region Properties
        /// <summary>
        /// Unique number for the account.
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// Email address of the account holder.
        /// </summary>

        public String EmailAddress { get; set; }

        public Decimal Balance { get; private set; }

        public AccountType AccountType { get; set; }

        public DateTime CreatedDate { get; private set; }
        #endregion

        #region Constructor
        public Account()
        {                       

            CreatedDate = DateTime.Now;

        }
        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into your account. 
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>

        public void Deposit(decimal amount)
        {
            // Balance = Balance + amount; 
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}

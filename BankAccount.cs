using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public  class BankAccount
    {
        // Properties
        private string accountNumber; // The unique identifier for the bank account
        private decimal accountBalance; // The current balance in the bank account

        // Constructor
        public BankAccount(string accountNumber)
        {
            // Initialize the account number with the provided value
            this.accountNumber = accountNumber;

            // Set the initial balance to 0
            this.accountBalance = 0m;
        }

        // Method to deposit money into the account
        public void Deposit(decimal depositAmount)
        {
            // Add the deposit amount to the current balance
            accountBalance += depositAmount;
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal withdrawalAmount)
        {
            // Check if there are sufficient funds before withdrawing
            if (withdrawalAmount > accountBalance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal not allowed.");
            }
            else
            {
                // Subtract the withdrawal amount from the current balance
                accountBalance -= withdrawalAmount;
            }
        }

        // Method to display the current balance
        public void DisplayBalance()
        {
            // Print out the account number and the current balance
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Current Balance: ${accountBalance:N2}");
        }
    }
}

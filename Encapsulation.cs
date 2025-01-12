using System;

namespace EncapsulationExample
{
    public class BankAccount
    {
        // Private field (Encapsulated data)
        private decimal balance;

        // Constructor to initialize balance
        public BankAccount(decimal initialBalance)
        {
            if (initialBalance >= 0)
            {
                balance = initialBalance;
            }
            else
            {
                Console.WriteLine("Initial balance must be non-negative.");
            }
        }

        // Public method to get the current balance
        public decimal GetBalance()
        {
            return balance;
        }

        // Public method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        // Public method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew: {amount:C}. New balance: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new BankAccount object with an initial balance
            BankAccount myAccount = new BankAccount(1000);

            // Display initial balance
            Console.WriteLine($"Initial balance: {myAccount.GetBalance():C}");

            // Perform some transactions
            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.Withdraw(1500); // Attempt to withdraw more than the available balance

            // Display final balance
            Console.WriteLine($"Final balance: {myAccount.GetBalance():C}");

            Console.ReadLine();
        }
    }
}

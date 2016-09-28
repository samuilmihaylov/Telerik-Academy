namespace _02.Bank_accounts.Models
{
    using System;

    public abstract class Account
    {
        // All accounts have customer, balance and interest rate (monthly based).
        // All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.

        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The balance can not be negative!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate must be positive value!");
                }
                this.interestRate = value;
            }
        }

        public abstract decimal InterestAmount(int months);

        public override string ToString()
        {
            return string.Format("{0} owner: {1}\nBalance: {2:C}\nInterest Rate: {3}%", GetType().Name, this.Customer, this.Balance, this.InterestRate);
        }
    }
}

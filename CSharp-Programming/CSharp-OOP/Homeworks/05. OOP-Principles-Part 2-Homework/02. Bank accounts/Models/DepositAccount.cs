namespace _02.Bank_accounts.Models
{
    using System;
    using _02.Bank_accounts.Interfaces;

    public class DepositAccount : Account, IWithdrawable, IDepositable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0;

            if (this.Balance < 1000)
            {
                Console.WriteLine("Bank balance must be more than {0} to count Interest Amount. Your balance is: {1:C}", 1000, this.Balance);
            }
            else
            {
                interestAmount = (this.InterestRate / 100) * months;
            }
            return interestAmount;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You can not deposit negative value");
            }
            this.Balance += amount;
        }

        public void WidhdrawMoney(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Not enough money in your bank account. Your balance is: {0:C}", this.Balance);
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

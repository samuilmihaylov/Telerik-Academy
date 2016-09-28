namespace _02.Bank_accounts.Models
{
    using Interfaces;
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("You can not deposit negative value");
            }
            this.Balance += amount;
        }

        public override decimal InterestAmount(int months)
        {
            decimal interestAmount = 0;

            if (this.Customer is Individual && months >= 3)
            {
                interestAmount = this.InterestRate / 100 * (months - 2);
            }
            else if (this.Customer is Company && months >= 2)
            {
                interestAmount = this.InterestRate / 100 * (months - 2);
            }
            return interestAmount;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

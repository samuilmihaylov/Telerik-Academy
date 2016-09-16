using _02.Bank_accounts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank_accounts.Models
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
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

            if (Customer is Individual && months > 6)
            {
                interestAmount = this.InterestRate / 100 * (months - 6);
            }
            else if (Customer is Company && months <= 12)
            {
                interestAmount = (this.InterestRate / 100 * months) / 2;
            }
            else if (Customer is Company && months > 12)
            {
                interestAmount = this.InterestRate / 100 * (months - 12);
            }
            return interestAmount;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

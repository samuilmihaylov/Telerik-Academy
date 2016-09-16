namespace _02.Bank_accounts
{
    using Enumerations;
    using Models;
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deposit Account: \n");

            var depositAccount = new DepositAccount(new Individual("Gosho Goshov", "11223344", GenderType.Male, new DateTime(1984, 11, 05)), 1400, 5);
            Console.WriteLine(depositAccount);
            depositAccount.DepositMoney(4000);
            depositAccount.WidhdrawMoney(400);
            // After deposit
            Console.WriteLine(depositAccount);

            Console.WriteLine("{0} - Interest amount: {1}%", depositAccount.GetType().Name, depositAccount.InterestAmount(8));
            Console.WriteLine();
            var companyDepositAccount = new DepositAccount(new Company("Apple", "11223344", "Tosho"), long.MaxValue, 300);
            Console.WriteLine(companyDepositAccount.ToString());

            Console.WriteLine();
            Console.WriteLine(new string('/', 100));
            Console.WriteLine();

            Console.WriteLine("Loan Account: ");
            Console.WriteLine();
            var loanDepositAccount = new LoanAccount(new Individual("Tosho Toshev", "22334455", GenderType.Male, new DateTime(1945, 11,2)), 5000, 7);
            Console.WriteLine(loanDepositAccount.ToString());
            Console.WriteLine("Interest amount {0}%", loanDepositAccount.InterestAmount(13));
            loanDepositAccount.DepositMoney(400);
            // After deposit
            Console.WriteLine(loanDepositAccount);

            Console.WriteLine();
            Console.WriteLine(new string('/', 100));
            Console.WriteLine();

            Console.WriteLine("Mortage Account: ");
            Console.WriteLine();
            var mortgageAccount = new MortgageAccount(new Individual("Kalinka Malinka", "44556677", GenderType.Female,new DateTime(1988, 4, 3)), 4444, 9);
            Console.WriteLine(mortgageAccount.ToString());
            Console.WriteLine("Interest amount {0}%", mortgageAccount.InterestAmount(12));

            Console.WriteLine();
        }
    }
}

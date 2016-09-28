namespace _02.Bank_accounts.Models
{
    using System;

    public class Company : Customer
    {
        private string director;

        public Company(string name, string clientNumber, string directorName) : base(name, clientNumber)
        {
            this.Director = directorName;
        }

        public string Director
        {
            get
            {
                return this.director;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the director can not be empty");
                }
                this.director = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + string.Format("Type of the account: {0}\nCompany name: {1}\nDirector: {2}",GetType().Name, this.Name, this.Director);
        }
    }
}

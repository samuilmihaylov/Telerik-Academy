namespace _02.Bank_accounts.Models
{
    using System;

    public abstract class Customer
    {
        private string name;
        private string clientNumber;

        public Customer(string name, string clientNumber)
        {
            this.Name = name;
            this.ClientNumber = clientNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The custommer's name can not be empty");
                }
                this.name = value;
            }
        }

        public string ClientNumber
        {
            get
            {
                return this.clientNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The custommer's client number can not be empty");
                }
                this.clientNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} \nWith client number: {1}", this.Name, this.ClientNumber);
        }
    }
}

namespace _02.Bank_accounts.Models
{
    using Enumerations;
    using System;

    public class Individual : Customer
    {
        private GenderType gender;
        private DateTime birthDate;

        public Individual(string name, string clientNumber, GenderType gender, DateTime birthDate) : base(name, clientNumber)
        {
            this.Gender = gender;
            this.BirthDate = birthDate;
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }


        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            private set
            {
                this.birthDate = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + string.Format("Type of the account: {0}\nBirth Date: {1:dd.MM.yyyy}\nGender: {2}", GetType().Name, this.BirthDate, this.Gender);
        }
    }
}

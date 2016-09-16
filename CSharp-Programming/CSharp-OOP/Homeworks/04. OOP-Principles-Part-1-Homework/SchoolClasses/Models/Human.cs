using SchoolClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses.Enumerations;

namespace SchoolClasses.Models
{
    public abstract class Human : IHuman
    {
        private string firstName;
        private string lastName;
        private GenderType gender;

        public Human(string firstName, string lastName, GenderType gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                this.lastName = value;
            }
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
    }
}

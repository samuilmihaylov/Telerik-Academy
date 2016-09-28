namespace PersonClass.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;
        private byte? age;

        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
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
                    throw new ArgumentException("Name cannot be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public byte? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name: {0} - Age: \"not specified\"", this.Name);
            }
            return string.Format("Name: {0} - Age: {1}", this.Name, this.Age);
        }
    }
}

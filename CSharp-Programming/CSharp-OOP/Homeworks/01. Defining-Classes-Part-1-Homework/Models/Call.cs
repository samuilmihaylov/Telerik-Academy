namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    class Call
    {
        // Fields

        private DateTime date;
        private string dialledPhoneNumber;
        private long duration;

        // Constructor

        public Call(string dialledPhoneNumber, long duration)
        {
            this.Date = DateTime.Now;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        // Properties

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = DateTime.Now;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The field can not be empty");
                }
                this.dialledPhoneNumber = value;
            }
        }

        public long Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duaration can not be a negative number!");
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Number: {0} : Duaration - {1} seconds, on {2}", this.DialledPhoneNumber, this.Duration, this.Date);
            sb.AppendLine();
            return sb.ToString();
        }
    }
}

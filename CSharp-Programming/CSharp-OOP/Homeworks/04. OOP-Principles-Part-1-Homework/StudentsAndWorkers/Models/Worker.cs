namespace StudentsAndWorkers.Models
{
    using System;

    public class Worker : Human
    {

        private const int MIN_WORK_HOURS = 1;
        private const int MAX_WORK_HOURS = 24;

        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The salary can not be negative value");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Work hours can not be less {0} or more than {1}!", MIN_WORK_HOURS, MAX_WORK_HOURS));
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (WorkHoursPerDay * 7);
        }

        public override string ToString()
        {
            return $"{"Name: " + this.FirstName + " " + this.LastName}";
        }
    }
}

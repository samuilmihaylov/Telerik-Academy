namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private const decimal callPricePerSecond = 0.37m;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> CallHistory;

        private static readonly GSM iPhone4S = new GSM("IPhone 4S", "Apple", 800.00m, "Random owner",
                                                        new Battery("Apple", 1000, 200, BatteryType.LiIon),
                                                        new Display(960, 640, "16M"));

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("GSM Specifications:");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendFormat("GSM Model - {0}", this.model);
            sb.AppendLine();
            sb.AppendFormat("GSM Manufacturer - {0}", this.manufacturer);
            sb.AppendLine();
            sb.AppendFormat("GSM Price - {0}", this.price);
            sb.AppendLine();
            sb.AppendFormat("GSM Owner - {0}", this.owner);
            sb.AppendLine();
            sb.AppendFormat("GSM Battery Specifications : Model - {1} , Type - {0} , talk time - {2} , idle time - {3}", this.Battery.BatteryType, this.Battery.Model, this.Battery.HoursTalk, this.Battery.HoursIdle);
            sb.AppendLine();
            sb.AppendFormat("GSM Display Specifications : Height - {0} , Width - {1} , Number of Colors - {2}", this.Display.Height, this.Display.Width, this.Display.NumberOfColors);
            sb.AppendLine();
            sb.AppendLine(new string('*', 110));
  
            return sb.ToString();
        }

        public void AddCall(string phoneNumber, long duration)
        {
            this.CallHistory.Add(new Call(phoneNumber, duration));
        }

        public void ShowCallHistory()
        {
            Console.WriteLine("Current call history:\n");

            foreach (var call in this.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }

        public void DeleteCalls(int index)
        {
            this.CallHistory.RemoveAt(index);
        }

        public void ClearAllCalls()
        {
            this.CallHistory.Clear();
        }

        public decimal TotalCallPrice()
        {
            decimal totalCallPrice = 0;
            decimal totalDuration = 0;

            foreach (var call in this.CallHistory)
            {
                totalDuration += call.Duration;
            }

            return totalCallPrice = totalDuration * callPricePerSecond;
        }
    }
}

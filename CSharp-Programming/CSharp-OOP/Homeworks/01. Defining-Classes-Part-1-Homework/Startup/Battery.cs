namespace MobilePhoneDevice
{
    using System;

    public class Battery
    {
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        private BatteryType batteryType;

        public Battery(string model, uint hoursIdle, uint hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The battery model can not be null or emtpy.");
                }
                this.model = value;
            }
        }

        public uint HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours must be a possitive number.");
                }
                this.hoursIdle = value;
            }
        }

        public uint HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours of talk time must be a possitive number.");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

    }
}

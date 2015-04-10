
using System;
namespace GSM
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;
        public string Model
        {
            get
            {
                if (this.model.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }
        public int HoursIdle
        {
            get
            {
                if (this.hoursIdle.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.hoursIdle;
            }
            private set
            {
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                if (this.hoursTalk.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.hoursTalk;
            }
            private set
            {
                this.hoursTalk = value;
            }
        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }
        public override string ToString()
        {
            return String.Format("Model: {0}, Hours idle: {1}, Hours talk: {2}, Type: {3}",
            this.model, this.hoursIdle, this.hoursTalk, this.type);
        }
    }
}

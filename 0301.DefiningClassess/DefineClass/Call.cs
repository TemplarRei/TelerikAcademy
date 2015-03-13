using System;

namespace GSM
{
    public class Call
    {
        public Call(DateTime dateAndTime, decimal durationInSeconds, string phoneNumber)
        {
            this.dateAndTime = dateAndTime;
            this.durationInSeconds = durationInSeconds;
            this.phoneNumber = phoneNumber;
        }

        private DateTime dateAndTime;
        private decimal durationInSeconds;
        private string phoneNumber;
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            private set { this.dateAndTime = value; }
        }


        public decimal DurationInSeconds
        {
            get { return this.durationInSeconds; }
            private set { this.durationInSeconds = value; }
        }


        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            private set { this.phoneNumber = value; }
        }

    }
}

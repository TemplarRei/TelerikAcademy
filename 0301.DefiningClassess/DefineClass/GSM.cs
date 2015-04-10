using System;
using System.Collections.Generic;
using System.Text;
namespace GSM
{
    class GSM
    {
        static void Main()
        {
            GSMTest test = new GSMTest();
            test.DisplayGSM();
            CallHistoryTest testTwo = new CallHistoryTest();
            testTwo.CallHistoryT();
        }
    }
    public enum BatteryType
    {
        LiPoly = 1, LiIon = 2, NiCd = 3, NiMH = 4
    }
    public class MobilePhone
    {
        //iPhone4S field
        public static MobilePhone iPhone4S;

        //fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        //iPhone4S constructor
        static MobilePhone()
        {
            iPhone4S = new MobilePhone("iPhone 4S", "Apple", 999.99M, "Not Me",
                       new Battery("Normal", 10, 1, BatteryType.LiIon), new Display(4.3f, 16000000));
        }
        //constructors
        public MobilePhone(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public MobilePhone(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.price = price;
        }

        public MobilePhone(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            this.owner = owner;
        }

        public MobilePhone(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, owner)
        {
            this.battery = battery;
            this.display = display;
            this.price = price;
        }


        public static MobilePhone IPhone4S
        {
            get { return iPhone4S; }
            private set { iPhone4S = value; }
        }
        //properties
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
        public string Manufacturer
        {
            get
            {
                if (this.manufacturer.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }
        public decimal? Price
        {
            get
            {
                if (this.price.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                if (this.owner.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get
            {
                if (this.battery.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                if (this.display.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }
        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callHistory); }
            private set { this.callHistory = value; }
        }
        //Methods
        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\n" +
                                 "Model: {1}\n" +
                                 "Price: {2}\n" +
                                 "Owner: {3}\n" +
                                 "Battery: {4}\n" +
                                 "Display: {5}",
                                 this.manufacturer, this.model, this.price, this.owner,
                                 this.battery.ToString(), this.display.ToString());
        }
        public List<Call> AddCalls(Call call)
        {
            this.callHistory.Add(call);
            return this.callHistory;
        }
        public List<Call> DeleteCalls(Call call)
        {
            this.callHistory.Remove(call);
            return this.callHistory;
        }
        public List<Call> ClearCallHistory()
        {
            this.callHistory.Clear();
            return this.callHistory;
        }
        public decimal CallsPrice(decimal pricePerMinute)
        {
            decimal totalDuration = 0;


            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].DurationInSeconds;
            }

            decimal totalPrice = (totalDuration / 60) * pricePerMinute;

            return totalPrice;
        }
    }

}
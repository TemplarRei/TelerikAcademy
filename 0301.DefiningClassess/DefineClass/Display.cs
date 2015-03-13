
using System;
namespace GSM
{
    public class Display
    {
        private float size;
        private long numberOfColours;
        public float Size
        {
            get
            {
                if (this.size.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.size;
            }
            private set
            {
                this.size = value;
            }
        }
        public long NumberOfColours
        {
            get
            {
                if (this.numberOfColours.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.numberOfColours;
            }
            private set
            {
                this.numberOfColours = value;
            }
        }
        public Display(float size, long colours)
        {
            this.size = size;
            this.numberOfColours = colours;
        }
        public override string ToString()
        {
            return String.Format("Size in inches: {0}, Number of colours: {1}",
            this.size, this.numberOfColours);
        }
    }
}

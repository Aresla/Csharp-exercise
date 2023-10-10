namespace Exercise010
{
    using System;
    public class Gauge
    {
        public int value { get; set; }
        public int meter;

        public Gauge()
        {
            this.meter = 0;
        }

        public void Increase()
        {
            if (value < 5)
            {
                this.value = value + 1;
            }
        }
        public void Decrease()
        {
            if (value > 0)
            {
                this.value = value - 1;
            }
        }
        public bool Full()
        {
            if (value == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
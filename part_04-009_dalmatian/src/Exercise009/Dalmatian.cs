namespace Exercise009
{
    using System;
    public class Dalmatian
    {
        public string name;
        public int spots { get; set; }

        public Dalmatian(string name, int spots)
        {
            this.name = name;
            this.spots = spots;
        }
    }
}
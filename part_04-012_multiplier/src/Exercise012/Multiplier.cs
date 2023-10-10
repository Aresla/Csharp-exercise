namespace Exercise012
{
    using System;
    public class Multiplier
    {
        public int number { get; set; }
        public Multiplier(int initialNumber)
        {
            this.number = initialNumber;
        }

        public int Multiply(int currentNumber)
        {
            this.number *= currentNumber;
            return this.number;
        }
    }
}
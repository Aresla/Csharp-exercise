namespace Exercise015
{
    public class Money
    {

        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }


        public Money Plus(Money addition)
        {
            Money newMoney = new Money(addition.euros + this.euros, addition.cents + this.cents);
            // create a new Money object that has the correct worth

            // return the new Money object
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            if (this.LessThan(decreaser))
            {
                Money newMoney = new Money(0, 0);
                return newMoney;
            }
            else if (this.euros > decreaser.euros & this.cents < decreaser.cents)
            {
                Money newMoney = new Money(this.euros - decreaser.euros - 1, this.cents + 100 - decreaser.cents);
                return newMoney;
            }
            else
            {
                Money newMoney = new Money(this.euros - decreaser.euros, this.cents - decreaser.cents);
                return newMoney;
            }
            // create a new Money object that has the correct worth

            // return the new Money object
        }

        public bool LessThan(Money compared)
        {
            // Do something here
            if (this.euros < compared.euros)
            {
                return true;
            }
            else if (this.euros <= compared.euros & this.cents < compared.cents)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string zero = "";
            if (this.cents <= 10)
            {
                zero = "0";
            }

            return this.euros + "." + zero + this.cents + "e";
        }
    }
}
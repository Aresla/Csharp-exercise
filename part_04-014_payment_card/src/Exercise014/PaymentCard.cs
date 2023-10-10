
namespace Exercise014
{
    public class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }


        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {balance} euros";
        }
        public void EatLunch()
        {
            if (balance >= 10.60)
            {
                this.balance = this.balance - 10.60;
            }
        }
        public void DrinkCoffee()
        {
            if (balance >= 2.00)
            {
                this.balance = this.balance - 2.00;
            }
        }
        public void AddMoney(double amount)
        {
            // write code here
            if ((balance + amount) < 150.00 & amount > 0)
            {
                this.balance = balance + amount;
            }
            else if ((balance + amount) >= 150.00 & amount > 0)
            {
                this.balance = 150.00;
            }
            else if (amount < 0)
            {
                this.balance = balance;
            }
        }
    }
}
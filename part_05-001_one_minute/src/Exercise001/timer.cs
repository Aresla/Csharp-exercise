namespace Exercise001
{
    public class Timer
    {
        public int hundredthsOfASecond { get; set; }
        public int seconds { get; set; }

        public Timer()
        {
            this.seconds = 0;
            this.hundredthsOfASecond = 0;
        }

        public void Advance()
        {
            this.hundredthsOfASecond = this.hundredthsOfASecond + 1;

            if (this.hundredthsOfASecond >= 100)
            {
                this.hundredthsOfASecond = 0;
                this.seconds = this.seconds + 1;
            }
            if (seconds == 60)
            {
                this.seconds = 0;
            }
        }

        public override string ToString()
        {
            if (seconds < 10 & this.hundredthsOfASecond < 10)
            {
                return "0" + this.seconds + ":0" + this.hundredthsOfASecond;
            }
            else if (seconds > 10 & this.hundredthsOfASecond < 10)
            {
                return this.seconds + ":0" + this.hundredthsOfASecond;
            }
            else if (seconds == 0 & this.hundredthsOfASecond < 10)
            {
                return "00:0" + this.hundredthsOfASecond;
            }
            else if (seconds == 0)
            {
                return "00:" + this.hundredthsOfASecond;
            }
            return "" + this.seconds + ":" + this.hundredthsOfASecond;
        }
    }
}
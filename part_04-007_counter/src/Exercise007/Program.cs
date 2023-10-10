namespace Exercise007
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DecreasingCounter my = new DecreasingCounter(10);
            my.PrintValue();
            my.Decrement();
            my.PrintValue();
            my.Reset();
            my.PrintValue();
        }
    }
}
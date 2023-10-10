namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            double squareRoot = Math.Sqrt(a + b);
            Console.WriteLine(squareRoot);
        }
    }
}

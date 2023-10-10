namespace Exercise016
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many days?");
            int a = Convert.ToInt32(Console.ReadLine());
            int res = a * 24 * 60 * 60;
            Console.WriteLine(res);
        }
    }
}

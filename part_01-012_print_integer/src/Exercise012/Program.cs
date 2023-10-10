namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You gave {a}");
        }
    }
}

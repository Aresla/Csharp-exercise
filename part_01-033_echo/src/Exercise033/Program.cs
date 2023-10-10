namespace Exercise033
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first string:");
            string a = Console.ReadLine();
            Console.WriteLine("Give the second string:");
            string b = Console.ReadLine();

            if (a == b)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }
        }
    }
}

namespace Exercise027
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                string[] pieces = input.Split(" ");
                Console.WriteLine(pieces[0]);
            }
        }
    }
}

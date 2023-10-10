namespace Exercise028
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
                int lastIndex = pieces.Length - 1;
                Console.WriteLine(pieces[lastIndex]);
            }
        }
    }
}
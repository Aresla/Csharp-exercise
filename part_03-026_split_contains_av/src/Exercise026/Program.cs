namespace Exercise026
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
                for (int i = 0; i < pieces.Length; i++)
                {
                    if (pieces[i].Contains("av"))
                    {
                        Console.WriteLine(pieces[i]);
                    }
                }

            }
        }
    }
}
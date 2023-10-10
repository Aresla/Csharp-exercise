namespace Exercise013
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                list.Add(input);
            }
            Console.WriteLine("Search for?");
            string inp = Console.ReadLine();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == inp)
                {
                    Console.WriteLine(inp + " was found!");
                    return;
                }
            }
            Console.WriteLine(inp + " was not found!");

        }
    }
}

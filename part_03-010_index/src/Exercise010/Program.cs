namespace Exercise010
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            Console.WriteLine("Search for?");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int ind = 0; ind < list.Count; ind++)
            {
                if (Convert.ToInt32(list[ind]) == num)
                {
                    Console.WriteLine(list[ind] + " is at index " + ind);
                }
            }
        }
    }
}

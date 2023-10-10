namespace Exercise012
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
            int sum = 0;
            //string[] parts = input.Split(",");
            foreach (var item in list)
            {
                sum += item;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}

namespace Exercise008
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
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                list.Add(number);
            }
            //Write your code here
            Console.WriteLine("From where?");
            int fromWhere = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where to?");
            int whereTo = Convert.ToInt32(Console.ReadLine());

            foreach (var item in list)
            {
                if (item >= fromWhere & item <= whereTo)
                {
                    System.Console.WriteLine(item);
                }
            }

        }
    }
}

namespace Exercise014
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(-1);
            numbers.Add(5);
            numbers.Add(1);
        }
        public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
        {
            Console.WriteLine($"The numbers in the range [{lowerLimit}, {upperLimit}]");
            foreach (var item in numbers)
            {
                if (item >= lowerLimit & item <= upperLimit)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

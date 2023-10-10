namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Write your method here:
            List<string> strings = new List<string>();

            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");
            RemoveLast(strings);
            strings.ForEach(Console.WriteLine);
        }

        public static void RemoveLast(List<string> strings)
        {
            int lastItemIndex = strings.Count - 1;
            strings.Remove(strings[lastItemIndex]);
        }
    }
}

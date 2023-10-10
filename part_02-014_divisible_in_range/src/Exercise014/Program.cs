namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here:
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            DivisibleByThreeInRange(first, second);
        }
        //Write your method here:
        public static void DivisibleByThreeInRange(int first, int second)
        {
            for (int i = first; i <= second; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

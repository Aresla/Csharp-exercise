namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);
        }

        public static void PrintArrayInStars(int[] array)
        {
            foreach (var item in array)
            {
                int num = item;
                while (num > 0)
                {
                    Console.Write("*");
                    num--;
                }
                Console.WriteLine();
            }
        }

    }
}
namespace Exercise011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //call your method here:
            int num = Convert.ToInt32(Console.ReadLine());
            PrintUntilNumber(num);
        }
        public static void PrintUntilNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }


}


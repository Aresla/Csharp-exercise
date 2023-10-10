namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int evenCount = 0;
            int oddCount = 0;
            Console.WriteLine("Give numbers:");

            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a != -1)
                {
                    sum += a;
                    count++;

                    if (a % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
                else
                {
                    Console.WriteLine("Thx! Bye!");
                    Console.WriteLine("Sum: " + sum);
                    Console.WriteLine("Numbers: " + count);
                    double average = Convert.ToDouble(sum) / Convert.ToDouble(count);
                    Console.WriteLine("Average: " + average);
                    Console.WriteLine("Even: " + evenCount);
                    Console.WriteLine("Odd: " + oddCount);
                    break;
                }
            }


        }
    }
}

namespace Exercise021
{
    using System;
    public class Program
    {
        public static void Main(String[] args)
        {
            ChristmasTree(4);
        }

        public static void PrintStars(int number)
        {
            while (number > 0)
            {
                Console.Write("*");
                number--;
            }
            Console.WriteLine("");
        }

        public static void PrintSpaces(int number)
        {
            while (number > 0)
            {
                Console.Write(" ");
                number--;
            }
        }

        public static void PrintRightTriangle(int size)
        {
            int spaices = size - 1;
            int stars = 1;
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(spaices);
                PrintStars(stars);
                spaices--;
                stars++;
            }
        }


        public static void ChristmasTree(int height)
        {
            int spaices = height - 1;
            int stars = 1;
            for (int i = 1; i <= height; i++)
            {
                PrintSpaces(spaices);
                PrintStars(stars);
                spaices--;
                stars = stars + 2;
            }

            PrintSpaces(height - 2);
            PrintStars(3);
            PrintSpaces(height - 2);
            PrintStars(3);
        }
    }
}

namespace Exercise017
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {

            List<TelevisionProgram> list = new List<TelevisionProgram>();
            // IMPLEMENT YOUR CODE IN HERE!
            while (true)
            {

                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (name == "")
                {
                    Console.Write("\n");
                    break;
                }

                Console.Write("Duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());

                list.Add(new TelevisionProgram(name, duration));
            }
            Console.Write("Program's maximum duration? ");
            int maxDuration = Convert.ToInt32(Console.ReadLine());

            foreach (TelevisionProgram televisionProgram in list)
            {
                if (televisionProgram.duration <= maxDuration)
                {
                    Console.Write(televisionProgram.ToString());
                    Console.WriteLine();
                }
            }
        }
    }
}
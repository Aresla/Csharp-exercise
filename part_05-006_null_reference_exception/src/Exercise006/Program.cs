namespace Exercise006
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implement a program, or modify the program so, that it causes 
            // the NullReferenceException -error

            String[] lines = new String[6];
            lines[0] = ("Never has a man influenced physics so profoundly as Niels Bohr in the early 1900's");
            lines[1] = ("Going back to this time period, little was known about atomic structure; Bohr set out");
            lines[2] = ("to end the obscurity of physics. However, things didn't come easy for Bohr. He had to");
            lines[3] = ("give up most of his life for physics and research of many hypothesis. But, this is why");
            lines[4] = ("you and I have even heard of the quantum theory and atomic structures. Bohr came");
            lines[5] = ("up with his quantum theory while studying...");


            int index = 0;
            while (index < lines.Length)
            {
                Console.WriteLine(lines[index]);
                index++;
            }
            lines = null;
            Console.WriteLine(lines[0]);
        }
    }
}
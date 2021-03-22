using System;

namespace assignmnet.Questions
{

    public class One
    {
        public void swap()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before x:{x} and Y:{y}");
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($"After x:{x} and Y:{y}");

        }
    }
}
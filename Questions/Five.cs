using System;

namespace assignmnet.Questions
{
    public class Five
    {
        enum list
        {
            one = 0,
            two = 5,
            three = 6,
            four = 10,
            five = 11
        }

        public void enums()
        {
            Console.WriteLine((int)list.one);
            Console.WriteLine((int)list.two);
            Console.WriteLine((int)list.three);
            Console.WriteLine((int)list.four);
            Console.WriteLine((int)list.five);
        }
    }
}
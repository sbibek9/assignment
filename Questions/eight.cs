using System;

namespace assignmnet.Questions
{
    public class eight
    {
        public void reverseString()
        {
            string x = null;
            x = Console.ReadLine();
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
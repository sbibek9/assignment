using System;

namespace assignmnet.Questions
{

    public class Three
    {
        public void reverse()
        {
            Console.WriteLine("Please enter a number: ");
            int n=0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Please enter a number");
            }
            int rem, rev = 0;
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reverse number is: " + rev);
        }
    }
}
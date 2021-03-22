using System;
using System.Collections.Generic;

namespace assignmnet.Questions
{
    public class Two
    {
        public void fives()
        {
            List<int> numberList = new List<int> { };
            Console.WriteLine("Input the length of the list? ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number: ");
            int j=0;
            while (j<x)
            {
                try
                {
                    numberList.Add(Convert.ToInt32(Console.ReadLine()));
                    j++;
                }
                catch (System.FormatException)
                {

                    Console.WriteLine("Please enter a number.");
                }
            }
            int count =0;
            for (int i = 0; i < x; i++)
            {
                if (numberList[i] == 5)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of 5's: " + count);
        }
    }
}
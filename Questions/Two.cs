using System;
using System.Collections.Generic;

namespace assignmnet.Questions
{
    public class Two
    {
        public void numberOfFives()
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
            foreach (var item in numberList)
            {
                if (item == 5){
                    count++;
                    
                }
                else if(item/10 > 1)
                {
                    count+=fivers(item);
                }
            }
            Console.WriteLine("Number of 5's: " + count);
        }
        public int fivers(int x){
            string val = x.ToString();
            int count = 0;
            foreach (var item in val)
            {
                if (item.Equals('5'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
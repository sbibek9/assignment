using System;
using assignmnet.Questions;
using System.Collections.Generic;

namespace assignmnet
{
    class Program
    {

        static void Main(string[] args)
        {
            //One one = new One();
            //One.swap();
            //Two two = new Two();
            //two.fives();
            //Three three = new Three();
            //three.reverse();
            //Four four = new Four();
            //four.generateRandomnos();
            //Five five = new Five();
            //five.enums();
            List<Six> students = new List<Six> { };
            Console.Write("Enter the number of students: ");
            int x = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[x];
            for (int i = 0; i < x; i++)
            {
                string name = Console.ReadLine();
                int marks = Convert.ToInt32(Console.ReadLine());
                arr[i] = marks.ToString();
                Six six = new Six(name, marks);
                students.Add(six);

            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arr[x-2]);
            


            //Seven seven = new Seven();
            //seven.convertDate();
            //eight eight = new eight();
            //eight.reverseString();
        }


    }
}

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
            //two.numberOfFives();
            //Three three = new Three();
            //three.reverse();
            //Four four = new Four();
            //four.generateRandomnos();
            //Five five = new Five();
            //five.getEnumValues();
            List<Students> students = new List<Students> { };
            //Console.Write("Enter the number of students: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //string[] arr = new string[x];
            //for (int i = 0; i < x; i++)
            //{
            //    string name = Console.ReadLine();
            //    int marks = Convert.ToInt32(Console.ReadLine());
            //    arr[i] = marks.ToString();
                Students students1 = new Students(name, marks);
            //    students.Add(students1);
//
            //}
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arr[x-2]);
            


            Seven seven = new Seven();
            seven.convertDateTime();
            //eight eight = new eight();
            //eight.reverseString();
        }


    }
}

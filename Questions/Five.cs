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

        public void getEnumValues()
        {
            foreach (var item in Enum.GetValues(typeof(list)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
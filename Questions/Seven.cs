using System;

namespace assignmnet.Questions
{
    public class Seven
    {
        public void convertDate()
        {
            DateTime dateTime = DateTime.Now;
            Console.Write("Current Time: ");
            Console.WriteLine(dateTime);
            Console.Write("UTC: ");
            DateTime tt = TimeZoneInfo.ConvertTimeToUtc(dateTime);
            Console.WriteLine(tt);
            foreach (var name in TimeZoneInfo.GetSystemTimeZones())
            {
                Console.WriteLine(name);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(tt,name));
            }

            
        }
    }
}
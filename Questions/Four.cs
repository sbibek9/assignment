using System;

namespace assignmnet.Questions
{
    public class Four
    {
        public void generateRandomnos()
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + random.Next(0,100));
            }
        }
    }
}
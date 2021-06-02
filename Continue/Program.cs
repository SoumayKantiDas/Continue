using System;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =1; i<= 10; i++)
            {
                if (i < 9)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

using System;

namespace employeeWeges
{
    class Program
    {
         static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(2);
            if (num == 0)
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("absent");
            }
        }
    }
}

using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Floating Number:");
            float num = Convert.ToSingle(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("zero");
            }
            else if (num > 1000000)
            {
                Console.WriteLine("Large positive");
            }
            else if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (Math.Abs(num) < 1)
            {
                Console.WriteLine("small");
            }
            else
            {
                Console.WriteLine("Negative");
            }

        }
    }
}

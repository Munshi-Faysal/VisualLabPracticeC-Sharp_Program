using System;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input First Number : ");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number : ");
            int b =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Third Number : ");
            int c =Convert.ToInt32(Console.ReadLine());

            if(a>b && b > c)
            {
                Console.WriteLine("Decreasing Order");
            }
            else if(a<b && a < c)
            {
                Console.WriteLine("Increasing Order");
            }
            else
            {
                Console.WriteLine("Go Editor");
            }

            
        }
    }
}

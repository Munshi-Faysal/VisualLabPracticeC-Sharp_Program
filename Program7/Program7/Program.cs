using System;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Array Size");
            int l = Convert.ToInt32(Console.ReadLine());
            int res;
            int[] answer = new int[l];
            Console.WriteLine("Enter Your Array");
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Specified Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i=0; i< answer.Length; i++)
            {
                
                for(int j=i; j< answer.Length - 1; j++)
                {
                    res = answer[i] + answer[j + 1];
                    if(res == n)
                    {
                        count++;
                        if (count == 1)
                        {
                            Console.WriteLine("Pairs Of the elements and their sum: ");
                        }
                       
                        Console.WriteLine(answer[i] + "+" + answer[j + 1]+ " = " + res);
                        break;
                    }
                    
                }
            }





           

        }
    }
}

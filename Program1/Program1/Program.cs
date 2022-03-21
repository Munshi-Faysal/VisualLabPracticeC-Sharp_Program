using System;

namespace Program1
{
    class Ritu  
    {
        public void number()  
        {
            Console.WriteLine("Ritu's Mobile Number");
        }
    }
    class MobileNumn : Ritu  
    {
        public string MobileNumber1 = "0163254696"; 
        public string MobileNumber2 = "0172563582";  
    }
    class Program
    {
        static void Main(string[] args)
        {
            MobileNumn mobile = new MobileNumn();
            mobile.number();
            Console.WriteLine(mobile.MobileNumber1 + " \n" + mobile.MobileNumber2);
        }
    }
}

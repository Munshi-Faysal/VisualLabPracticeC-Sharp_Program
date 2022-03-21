using System;

namespace program5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Jsc Marks In English");
            int marksJSC =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Jsc Marks In English");
            int marksSSc =Convert.ToInt32(Console.ReadLine());

            float result = (((marksJSC * 25 )/ 100))+(((marksSSc * 75 )/ 100));

            if((result > 100)||(result<0)){
                Console.WriteLine("Invalid Marks");
            }
            else if(result >= 80) {
                Console.WriteLine("HSC Grade : A");
            }
            else if(result >= 70) {
                Console.WriteLine("HSC Grade : B");
            }
            else if(result >= 60){
                Console.WriteLine("HSC Grade : C");
            }
            else if(result >= 50){
                Console.WriteLine("HSC Grade : D");
            }
            else {
                Console.WriteLine("HSC Grade : F");
            }


            
        }
    }
}

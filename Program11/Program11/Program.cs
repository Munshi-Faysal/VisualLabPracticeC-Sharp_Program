using System;

namespace Program11
{
    class Program
    {
        static void Main(string[] args)
        {
            Class c = new Class();
            c.batch();
            Classone c1 = new Classone();
            c1.SectionA();
            ClassTwo c2 = new ClassTwo();
            c2.SectionC();
            c2.SectionD();
        }
    }
    public class Class
    {
        public void batch()
        {
            Console.WriteLine("Batch 01");
        }
    }
    public class Classone : Class
    {
        public void SectionA()
        {
            Console.WriteLine("Total number of students are 20");
        }
    }
    public class ClassTwo : Class
    {
        public void SectionC()
        {
            Console.WriteLine("Total number of students is 30");
        }
        public void SectionD()
        {
            Console.WriteLine("Total number of students is 40");
        }
    }

}

using System;

namespace Program3
{

    class Program
    {
        public static void StudentTest()
        {
            Student std = new Student();
            std.Name = "Munshi Faysal";
            std.AverageMark = 85;
            std.EligibleToEnroll();
        }

        public static void ProfessorTest()
        {
            Professor pro = new Professor();
            pro.Name = "Shakil Ahmed";
            pro.Salary = 50000;
            pro.PurchaseParkingPass();
        }
        static void Main(string[] args)
        {
            StudentTest();
            ProfessorTest();
        }
    }

    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public void Validate()
        {
            if (Street != "" && City != "" && State != "" && PostalCode != "" && Country != "")
                Console.WriteLine("Valid address");
        }
    }
    class Person : Address
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public void PurchaseParkingPass()
        {
            Console.WriteLine(Name + " just purchase a parking pass");
        }
    }

    class Student : Person
    {
        public int StudentNumber { get; set; }
        public decimal AverageMark { get; set; }

        public void EligibleToEnroll()
        {
            if (AverageMark > 70) Console.WriteLine(Name + " is eligible to enroll");
            else Console.WriteLine(Name + " is not eligible to enroll");
        }
    }

    class Professor : Person
    {
        public int Salary { get; set; }
    }
}

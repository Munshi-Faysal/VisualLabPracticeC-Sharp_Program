using System;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(5.6, 8.4);
            rec.area();

            Ellipse ell = new Ellipse(7.8, 9.3);
            ell.area();

            Triangle tri = new Triangle(5, 9, 40);
            tri.area();
        }
    }
    class Shape
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    class Rectangle : Shape
    {
        public double width { get; set; }
        public double hight { get; set; }
        public Rectangle(double width, double hight)
        {
            this.width = width;
            this.hight = hight;
        }
        public void area()
        {
            double result = width * hight;
            Console.WriteLine("The area of the rectangle: " + result);
        }
    }

    class Ellipse : Shape
    {
        public double major_axis { get; set; }
        public double minor_axis { get; set; }
        public Ellipse(double major_axis, double minor_axis)
        {
            this.major_axis = major_axis;
            this.minor_axis = minor_axis;
        }
        public void area()
        {
            double result = Math.PI * major_axis * minor_axis;
            Console.WriteLine("The area of the ellipse: " + result);
        }
    }

    class Triangle : Shape
    {
        public double sideOne { get; set; }
        public double sideTwo { get; set; }
        public double angle { get; set; }
        public Triangle(double sideOne, double sideTwo, double angle)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.angle = angle;
        }
        public void area()
        {
            double result = 0.5 * sideOne * sideTwo * Math.Sin(angle);
            Console.WriteLine("The area of the Triangle: " + result);
        }
    }

}

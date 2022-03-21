using System;

namespace Program10
{
    class ABCIceCream
    {
        public virtual void Icecream()
        {
            Console.WriteLine("Default Vanilla Icecream");
        }
    }
    class XIceCream : ABCIceCream
    {
        public override void Icecream()
        {
            Console.WriteLine("Default Vanilla Icecream");
        }
    }
    class YIceCream : ABCIceCream
    {
        public override void Icecream()
        {
                Console.WriteLine("Vanilla with Chocolate Icecream");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ABCIceCream abcIceCream = new ABCIceCream();
            ABCIceCream xIceCreame = new XIceCream();
            ABCIceCream yIceCreame = new YIceCream();

            abcIceCream.Icecream();
            xIceCreame.Icecream();
            yIceCreame.Icecream();

        }
    }
}

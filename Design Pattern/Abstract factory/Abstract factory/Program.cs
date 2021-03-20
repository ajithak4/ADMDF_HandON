using Abstract_factory.AbstractClass;
using System;

namespace Abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter car Name ");
            string car = Console.ReadLine();
            AbstractFactory factory = FactoryGetter.Create(car);
            ITire tire = factory.makeTire();
            tire.GetTire();
            IHeadLight headlight = factory.makeHeadLight();
            headlight.GetHeadLight();
            Console.ReadLine();
        }
    }
}

using System;

namespace BuilderPattern
{
	class Program
	{
		static void Main(string[] args)
		{
            //create director and builders

            Director director = new Director();

            Builder child = new ConcreteChild();
            Builder adult = new ConcreteAdult();

            director.Construct(child);
            Product p1 = child.GetResults();
            Console.WriteLine("\nChild Package");
            p1.Show();

            director.Construct(adult);
            Product p2 = adult.GetResults();
            Console.WriteLine("Adult Package");
            p2.Show();




            Console.ReadLine();
        }
	}
}

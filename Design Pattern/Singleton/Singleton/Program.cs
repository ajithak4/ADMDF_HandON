using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DBConn obj1 = DBConn.getInstance();
            DBConn obj2 = DBConn.getInstance();
            if (obj1.Equals(obj2))
            {
                Console.WriteLine("Same Instance");
            }
            Console.ReadLine();
        }
    }
}

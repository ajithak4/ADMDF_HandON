using Abstract_factory.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_factory.Concrete_class
{
    public class MercedesHeadLight : IHeadLight
    {
        public void GetHeadLight()
        {
            Console.WriteLine("Mercedes HeadLight");
        }
    }
}

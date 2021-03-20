using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_factory.AbstractClass
{
    public abstract class AbstractFactory
    {
        public abstract IHeadLight makeHeadLight();
        public abstract ITire makeTire();
    }
}

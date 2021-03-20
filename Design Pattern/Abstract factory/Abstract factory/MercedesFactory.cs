using Abstract_factory.AbstractClass;
using Abstract_factory.Concrete_class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_factory
{
    public class MercedesFactory : AbstractFactory
    {
        public override IHeadLight makeHeadLight()
        {
            return new MercedesHeadLight();
        }

        public override ITire makeTire()
        {
            return new MercedesTire();
        }
    }
}

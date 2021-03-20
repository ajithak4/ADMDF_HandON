using Abstract_factory.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_factory
{
   public  class FactoryGetter
    {
        public static AbstractFactory Create(string car)
        {
            switch (car)
            {
                case "Mercedes":
                    return new MercedesFactory();
                case "Audi":
                    return new AudiFactory();
                default:
                    return null;
            }
        }
    }
}

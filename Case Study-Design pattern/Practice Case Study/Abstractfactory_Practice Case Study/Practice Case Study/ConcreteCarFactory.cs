using System;
using System.Collections.Generic;
using System.Text;
using static Practice_Case_Study.Program;

namespace Practice_Case_Study
{
    public class ConcreteCarFactory : CarFactory
    {


        public void MakeLuxuryCar(Location location, CarType carType)
        {
            new LuxuryCar(carType, location);
        }

        public void MakeMicroCar(Location location, CarType carType)
        {

            new MicroCar(carType, location);
        }

        public void MakeMiniCar(Location location, CarType carType)
        {

            new MiniCar(carType, location);
        }
    }
}

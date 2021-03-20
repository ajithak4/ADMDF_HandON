using System;
using System.Collections.Generic;
using System.Text;
using static Practice_Case_Study.Program;

namespace Practice_Case_Study
{
    public interface CarFactory
    {
        void MakeMicroCar(Location location, CarType carType);
        void MakeMiniCar(Location location, CarType carType);
        void MakeLuxuryCar(Location location, CarType carType);
    }
}

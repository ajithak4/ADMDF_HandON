using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_parameters
{
    class Program
    {
        public enum Mode
        {
            OBL , PARC
        }

        public enum Track
        {
            JAVA , DOTNET
        }

        static void Main(string[] args)
        {
            
            GetCohortDetails("first",100,Mode.OBL,Track.DOTNET,"ASP.NET");
            //GetCohortDetails("first", 100, Track.DOTNET, Mode.OBL, "ASP.NET");

            GetCohortDetails(name:"first", count: 100,t: Track.DOTNET,m: Mode.OBL,currentmodule: "ASP.NET");
            Console.Read();
        }
        public static void GetCohortDetails(string name,int count,Mode m,Track t,string currentmodule)
        {
            Console.WriteLine($" It is {name} with {count} GenCs undergoing training for {t} thru {m}. The current module of training is {currentmodule}");


        }
    }
}

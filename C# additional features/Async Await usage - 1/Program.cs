using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await_usage___1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Method1();
            

        }
        private static async Task Method1()
        {
            string output = await ReturnString();
            Console.WriteLine(output);
            Console.Read();
            

        }

        private static async Task<String> ReturnString()
        {
            string string1 = "This is a test string";
             Thread.Sleep(500);
            return string1;
        }

    }
}

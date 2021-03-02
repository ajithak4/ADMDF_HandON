using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails("Amazon","pen");
            OrderDetails("Flipkart", "pencil",10,false);
            Console.Read();

        }
        public static void OrderDetails(string Sellername,string productname,int orderqty=1,bool isReturnable=true)
        {
            Console.WriteLine($"Here is the order detail – {orderqty} number of {productname} by{Sellername} is ordered. It’s returnable status is {isReturnable}");
        }
    }
}

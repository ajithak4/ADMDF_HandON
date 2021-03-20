using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_practice_case_study
{
    class JohnObserver : INotificationObserver
    {

        public string Name { get { return "John"; } }




        public void OnServerDown()
        {

            Console.WriteLine(Name + " server is down");
        }
    }
}

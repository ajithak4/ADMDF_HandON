using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_practice_case_study
{
    class SteveObserver : INotificationObserver
    {

        public string Name { get => "Steve"; }

        public void OnServerDown()
        {

            Console.WriteLine(Name + " Server is down");
        }
    }
}

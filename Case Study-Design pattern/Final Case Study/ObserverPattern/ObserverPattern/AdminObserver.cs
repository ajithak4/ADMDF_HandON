using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class AdminObserver : INotificationObserver
    {

		private string processname;
		
		public string ProcessName { get => processname; set => processname = value; }

		public void EmailNotification()
        {
            Console.WriteLine("Email Notification \n Ticket Count Exceeded for {0}", ProcessName);
        }

        public void SMSNotification()
        {
            Console.WriteLine("-SMS Notification \nTicket Count Exceeded for {0}", ProcessName);
        }

        public void WhatsAppNotification()
        {
            Console.WriteLine("WhatsApp Notification \n Ticket Count Exceeded for {0}", ProcessName);
        }
    }
}

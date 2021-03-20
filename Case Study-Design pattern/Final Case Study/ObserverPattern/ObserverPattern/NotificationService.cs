using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class NotificationService : INotificationService
    {
        private List<INotificationObserver> subscribers = new List<INotificationObserver>();


        public void AddSubscriber(INotificationObserver observer)
        {
            subscribers.Add(observer);
            Console.WriteLine("Admin added");
        }
        public void book(int i,string eventname)
        {
            if (i > 100)
            {
                NotifySubscriber(eventname);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Tickets Booked");
                
            }
        }
        public void NotifySubscriber(string events)
        {
            Console.WriteLine("Notification for Admin");

            foreach (var i in subscribers)
            {
               
                i.ProcessName = events;
                i.EmailNotification();
                i.WhatsAppNotification();
                i.SMSNotification();
               
            }

        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            subscribers.Remove(observer);
            Console.WriteLine("Admin Removed");
        }
    }
}

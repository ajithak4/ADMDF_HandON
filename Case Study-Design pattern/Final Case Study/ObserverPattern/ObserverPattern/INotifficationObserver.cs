using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface INotificationObserver
    {
        string ProcessName { get; set; }
        void EmailNotification();
        void WhatsAppNotification();
        void SMSNotification();
    }
}

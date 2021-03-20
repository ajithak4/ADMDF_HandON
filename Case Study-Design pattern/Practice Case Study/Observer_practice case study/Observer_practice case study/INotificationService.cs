using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_practice_case_study
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifySubscriber();
    }
}

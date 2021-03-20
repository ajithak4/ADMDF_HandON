using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_practice_case_study
{
    public interface INotificationObserver
    {
        string Name { get; }

        void OnServerDown();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(IUser user, string message);
    }
}

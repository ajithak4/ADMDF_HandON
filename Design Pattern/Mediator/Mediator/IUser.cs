using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface IUser
    {
        string Name { get; set; }
        void RecieveMesage(IUser u, string message);
        void SendMesage(string message);
    }
}

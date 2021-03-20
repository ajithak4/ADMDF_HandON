using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class BasicUser : IUser
    {

        public string Name { get; set; }


        ChatMediator chat = new ChatMediator();



        public void RecieveMesage(IUser u, string message)
        {
            Console.Write(this.Name +" - ");
            Console.WriteLine(message + " Received from  " + u.Name);
        }

        public void SendMesage(string message)
        {
            chat.SendMessage(this, message);
        }
    }
}

using System;

namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
            ChatMediator chat = new ChatMediator();
            IUser user1 = new PremiumUser() { Name = "PremiumUser1" };
            IUser user2 = new BasicUser() { Name = "basicuser 1" };
            IUser user3 = new BasicUser() { Name = "basicuser 2" };
            chat.AddUser(user1);
            chat.AddUser(user2);
            chat.AddUser(user3);



            chat.SendMessage(user2, "Hello");
            chat.SendMessage(user1, "Hey");
            Console.Read();
        }
	}
}

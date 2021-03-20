using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class MessageSubscriberOne : Observer

	{
		public void update(message m)
		{

			Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());

		}

	}
	public class MessageSubscriberTwo : Observer

	{
		public void update(message m)
		{

			Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());

		}

	}
	public class MessageSubscriberThree : Observer

	{
		public void update(message m)
		{

			Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());

		}

	}
}

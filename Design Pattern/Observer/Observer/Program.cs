using System;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			MessageSubscriberOne s1 = new MessageSubscriberOne();

			MessageSubscriberTwo s2 = new MessageSubscriberTwo();

			MessageSubscriberThree s3 = new MessageSubscriberThree();

			MessagePublisher p = new MessagePublisher();

			//p.attach(s1);

			//p.attach(s2);

			//p.notifyUpdate(new message("First Message")); //s1 and s2 will receive the update

			//p.detach(s1);

			//p.attach(s3);

			
			//p.notifyUpdate(new message("Second Message")); //s2 and s3 will receive the update

			p.attach(s1);

			p.attach(s2);
			
			p.ChangeState(2);

		}
	}
}

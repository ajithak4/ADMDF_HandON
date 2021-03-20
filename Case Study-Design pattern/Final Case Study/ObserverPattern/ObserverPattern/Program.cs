using System;

namespace ObserverPattern
{
    class Program
    {
        public enum events
        {
            Dance, Game, school
        }

        static void Main(string[] args)
        {

			AdminObserver admin = new AdminObserver();
			
			NotificationService notificationService = new NotificationService();

			notificationService.AddSubscriber(admin);
			

			Console.WriteLine("Welcome to the Events");

			Console.WriteLine("Enter the Event Name");
			string eventname = Console.ReadLine();


			Console.WriteLine("Enter the number of tickets");
			int i = Convert.ToInt32(Console.ReadLine());

			notificationService.book(i, eventname);

			Console.WriteLine();

			notificationService.RemoveSubscriber(admin);
			Console.ReadLine();
		}
        
    }
}

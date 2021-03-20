using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class MessagePublisher : Subject
	{

		private List<Observer> observers = new List<Observer>();
		private int getState = 1;
		public int GetState { get => getState; set => value = getState; }


		public void attach(Observer o)
		{

			observers.Add(o);

		}
		public void ChangeState(int val)
		{
			if (val != getState)
			{

				GetState = val;

				notifyUpdate(new message("Subject State has been changed"));
			}
		}
		public void detach(Observer o)
		{
			observers.Remove(o);
		}
		public void notifyUpdate(message m)
		{
			foreach (Observer o in observers)
			{
				o.update(m);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public interface Subject

	{

		public void attach(Observer o);

		public void detach(Observer o);

		public void notifyUpdate(message m);
	}
	
}
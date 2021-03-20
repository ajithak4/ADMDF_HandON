using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	public class message
	{
		  String messageContent;
			public message(String m) { this.messageContent = m; }
		public String getMessageContent() { return messageContent; }
	}
}

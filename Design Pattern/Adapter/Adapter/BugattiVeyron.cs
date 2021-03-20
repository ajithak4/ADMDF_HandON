using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
	public class BugattiVeyron :Movable,Price
	{
		 public  double getSpeed()
	{ 
		return 268; 
	}
		public double getPrice()
		{
			return 3000;
		}
	}

}

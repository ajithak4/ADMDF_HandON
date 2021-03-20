using System;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			BugattiVeyron bugattiVeyron = new BugattiVeyron();
			Console.WriteLine("Speed in mph");
			Console.WriteLine(bugattiVeyron.getSpeed());

			MovableAdapter movableAdapter = new MovableAdapterImpl(bugattiVeyron);
			Console.WriteLine("Speed in km/h");
			Console.WriteLine(movableAdapter.getSpeed());

			Console.WriteLine("Price in USD");
			Console.WriteLine(bugattiVeyron.getPrice());

			PriceAdapter priceAdapter = new PriceAdapterUsdToEuro(bugattiVeyron);
			Console.WriteLine("Price in Euro");
			Console.WriteLine(priceAdapter.getPrice());

			Console.ReadLine();
		}
	}
}

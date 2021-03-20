using System;

namespace Facade
{
	class FacadeDemo
	{
		static void Main(string[] args)
		{
			ShapeMaker s = new ShapeMaker();

			s.DrawCircle();
			s.DrawRectangle();
			s.DrawSquare();

			Console.Read();
		}
	}
}

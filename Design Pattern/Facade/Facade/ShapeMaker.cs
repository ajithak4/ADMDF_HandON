using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class ShapeMaker
    {
        public Shape circle;
        public Shape rectangle;
        public Shape square;

        public ShapeMaker()
        {


        }

        public void DrawCircle()
        {
            circle = new Circle();
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle = new Rectangle();
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square = new Square();
            square.Draw();
        }

    }
}

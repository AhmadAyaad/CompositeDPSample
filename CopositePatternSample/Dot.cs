using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternSample
{
    class Dot : IGraphic
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Dot is drawn");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"dot is movinf from {x} to {y}");
        }

        public virtual void Display()
        {
            Console.WriteLine($"dot=> x:{X} , y: {Y} ");
        }
    }
}

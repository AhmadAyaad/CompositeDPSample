using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternSample
{
    class Circle : Dot
    {
        public int Radius { get; set; }
        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Circle is drawn at x: {X} , y: {Y} , raduis:{Radius}");
        }
        public override void Display()
        {
            Console.WriteLine($"Circle =>   x: {X} , y:{Y} , radius: {Radius}");
        }
    }
}

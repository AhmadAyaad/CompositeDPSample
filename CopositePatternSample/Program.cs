using System;

namespace CompositePatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CompoundGraphic compoundGraphic = new CompoundGraphic();
            compoundGraphic.Add(new Dot(5, 4));
            compoundGraphic.Add(new Circle(10, 20, 2));
            compoundGraphic.Display();
        }
    }
}

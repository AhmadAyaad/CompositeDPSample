using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternSample
{
    class CompoundGraphic : IGraphic
    {
        List<IGraphic> graphics; 
        public CompoundGraphic()
        {
            graphics = new List<IGraphic>();
        }
        public void Draw()
        {
            Console.WriteLine("");
        }

        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Add(IGraphic graphic)
        {
            graphics.Add(graphic);
        }
        public void Remove(IGraphic graphic)
        {
            graphics.Remove(graphic);
        }
        public void Display()
        {
            foreach (var item in graphics)
            {
                item.Display();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternSample
{
    interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
        void Display();
    }
}

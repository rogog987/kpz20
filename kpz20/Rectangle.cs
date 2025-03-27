using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz20
{
    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}

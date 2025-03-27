using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz20
{
    public class Triangle : IShape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}

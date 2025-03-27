using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz20
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
        void Visit(Triangle triangle);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz20
{
    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}

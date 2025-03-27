using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kpz20
{
    public class XmlExportVisitor : IShapeVisitor
    {
        private readonly XElement _root;

        public XmlExportVisitor()
        {
            _root = new XElement("Shapes");
        }
        public void Visit(Rectangle rectangle)
        {
            _root.Add(new XElement("Rectangle",
                new XAttribute("Width", rectangle.Width),
                new XAttribute("Height", rectangle.Height)
            ));
        }
        public void Visit(Circle circle)
        {
            _root.Add(new XElement("Circle",
                new XAttribute("Radius", circle.Radius)
            ));
        }

        public void Visit(Triangle triangle)
        {
            _root.Add(new XElement("Triangle",
                new XAttribute("Base", triangle.Base),
                new XAttribute("Height", triangle.Height)
            ));
        }

        public string GetXml()
        {
            return _root.ToString();
        }
    }
}
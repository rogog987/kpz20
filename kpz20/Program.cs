using kpz20;
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 7)
        };
                
        XmlExportVisitor xmlExporter = new XmlExportVisitor();

        foreach (var shape in shapes)
        {
            shape.Accept(xmlExporter);
        }

        Console.WriteLine("Експортовані фігури у форматі XML:");
        Console.WriteLine(xmlExporter.GetXml());

      //  Console.WriteLine(xmlExporter.
    }
}

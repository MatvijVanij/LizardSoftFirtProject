using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Helpers
{
    public interface ISerializable
    {
        string Type { get; set; }
        Point StartPoint { get; set; }
        Point EndPoint { get; set; }
        Color Color { get; set; }
        float Width { get; set; }
        List<string> ListForTextClass { get; set; }
        List<string> ListForTextField { get; set; }
        List<string> ListForTextMethod { get; set; }
    }
}

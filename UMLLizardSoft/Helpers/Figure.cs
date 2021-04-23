using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Helpers
{
    public class Figure : ISerializable
    {
        public string Type { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public float Width { get; set; }
        public List<string> ListForTextClass { get; set; }
        public List<string> ListForTextField { get; set; }
        public List<string> ListForTextMethod { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Rectangles
{
    public abstract class AbstractRectangle
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            points.Add(EndPoint);

            return points;
        }

        public abstract void Draw(Graphics graphics, Pen pen);
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Arrows
{
    public abstract class AbstractArrow
    {
        

        protected Pen _pen = new Pen(Color.Black, 5);

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            points.Add(StartPoint);
            int middle = (StartPoint.X + EndPoint.X) / 2;

            points.Add(new Point(middle, StartPoint.Y));
            points.Add(new Point(middle, EndPoint.Y));
            points.Add(EndPoint);

            double angle = Math.Atan2(StartPoint.X - EndPoint.X, StartPoint.Y - EndPoint.Y);

            return points;
        }

        public abstract void Draw(Graphics graphics);
    }
}

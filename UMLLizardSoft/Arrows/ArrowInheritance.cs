using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Arrows
{
    public class ArrowInheritance : AbstractArrow
    {
        public override void Draw(Graphics graphics)
        {
            double angle = Math.Atan2(StartPoint.X - EndPoint.X, StartPoint.Y - EndPoint.Y);

            //Point pointSecond = new Point(Convert.ToInt32(x2 + 23 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 23 * Math.Cos(angle - 0)));
            //Point point1 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
            //Point point2 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));
            //Point point3 = EndPoint;
            Point point1 = new Point(EndPoint.X, EndPoint.Y);
            Point point2 = new Point(EndPoint.X - 30, EndPoint.Y - 30);
            Point point3 = new Point(EndPoint.X - 30, EndPoint.Y + 30);

            Point[] points = { point1, point2, point3 };

            graphics.DrawPolygon(_pen, points);

            graphics.DrawLines(_pen, GetPoints().ToArray());

        }
    }
}

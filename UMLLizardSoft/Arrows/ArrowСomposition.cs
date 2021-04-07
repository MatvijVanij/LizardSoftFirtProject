using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Arrows
{
    public class ArrowСomposition : AbstractArrow
    {
        public override void Draw(Graphics graphics)
        {
            //SolidBrush solidBrush = new SolidBrush(_pen.Color);

            double angle = Math.Atan2(StartPoint.X - EndPoint.X, StartPoint.Y - EndPoint.Y);

            //Point pointSecond = new Point(Convert.ToInt32(x2 + 50 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(angle - 0)));
            //Point point1 = new Point(Convert.ToInt32(x2 + 50 * Math.Sin(angle - 0)), Convert.ToInt32(y2 + 50 * Math.Cos(angle - 0)));
            //Point point2 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
            //Point point3 = _pointSecond;
            //Point point4 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));
            //Point[] points = { point1, point2, point3, point4 };

            //_graphics.DrawPolygon(_pen, points);

            //_graphics.FillClosedCurve(solidBrush, points);

            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Arrows
{
    public class ArrowImplementation : AbstractArrow
    {
        public ArrowImplementation()
        {
            _penEnd.DashStyle = DashStyle.Dash;
        }

        public override void Draw(Graphics graphics)
        {
            if (StartPoint.X > EndPoint.X)
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 30, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X + 30, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                graphics.DrawPolygon(_pen, points);
            }
            else if (StartPoint.X < EndPoint.X)
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X - 30, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X - 30, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                graphics.DrawPolygon(_pen, points);

            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 20, EndPoint.Y + 30);
                Point point3 = new Point(EndPoint.X - 20, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                graphics.DrawPolygon(_pen, points);
            }
            else
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 20, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X - 20, EndPoint.Y - 30);

                Point[] points = { point1, point2, point3 };

                graphics.DrawPolygon(_pen, points);
            }

            graphics.DrawLines(_penEnd, GetPoints().ToArray());
        }
    }
}

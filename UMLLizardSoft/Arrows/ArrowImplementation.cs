using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLLizardSoft.Arrows
{
    public class ArrowImplementation : AbstractArrow
    {
        Point tmp = new Point();

        public override void Draw(Graphics graphics,Pen pen)
        {
            DrawingError();

            if (StartPoint.X > EndPoint.X)
            {
                pen.DashStyle = DashStyle.Solid;

                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 30, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X + 30, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                tmp = new Point(EndPoint.X + 30, EndPoint.Y);

                graphics.DrawPolygon(pen, points);
            }
            else if (StartPoint.X < EndPoint.X)
            {
                pen.DashStyle = DashStyle.Solid;

                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X - 30, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X - 30, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                tmp = new Point(EndPoint.X - 30, EndPoint.Y);

                graphics.DrawPolygon(pen, points);

            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                pen.DashStyle = DashStyle.Solid;

                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 20, EndPoint.Y + 30);
                Point point3 = new Point(EndPoint.X - 20, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                tmp = new Point(EndPoint.X, EndPoint.Y + 30);

                graphics.DrawPolygon(pen, points);
            }
            else
            {
                pen.DashStyle = DashStyle.Solid;

                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 20, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X - 20, EndPoint.Y - 30);

                Point[] points = { point1, point2, point3 };

                tmp = new Point(EndPoint.X, EndPoint.Y - 30);

                graphics.DrawPolygon(pen, points);
            }

            EndPoint = tmp;
            pen.DashStyle = DashStyle.Dash;
            graphics.DrawLines(pen, GetPoints().ToArray());
            pen.DashStyle = DashStyle.Solid;
        }
    }
}
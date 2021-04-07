using System.Drawing;

namespace UMLLizardSoft.Arrows
{
    public class ArrowAggregation : AbstractArrow
    {
        public override void Draw(Graphics graphics)
        {
            if (StartPoint.X > EndPoint.X)
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 30, EndPoint.Y - 20);
                Point point3 = new Point(EndPoint.X + 30, EndPoint.Y + 20);
                Point point4 = new Point(EndPoint.X + 60, EndPoint.Y);

                Point[] points = { point1, point2, point4, point3 };

                graphics.DrawPolygon(_pen, points);
            }
            else if (StartPoint.X < EndPoint.X)
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X - 30, EndPoint.Y - 20);
                Point point3 = new Point(EndPoint.X - 30, EndPoint.Y + 20);
                Point point4 = new Point(EndPoint.X - 60, EndPoint.Y);

                Point[] points = { point1, point2, point4, point3 };

                graphics.DrawPolygon(_pen, points);

            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 20, EndPoint.Y + 30);
                Point point3 = new Point(EndPoint.X - 20, EndPoint.Y + 30);
                Point point4 = new Point(EndPoint.X, EndPoint.Y + 60);

                Point[] points = { point1, point2, point4, point3 };

                graphics.DrawPolygon(_pen, points);
            }
            else
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 20, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X - 20, EndPoint.Y - 30);
                Point point4 = new Point(EndPoint.X, EndPoint.Y - 60);

                Point[] points = { point1, point2, point4, point3 };

                graphics.DrawPolygon(_pen, points);
            }

            graphics.DrawLines(_pen, GetPoints().ToArray());
        }
    }
}
using System.Drawing;

namespace UMLLizardSoft.Arrows
{
    public class ArrowAssociation : AbstractArrow
    {
        public override void Draw(Graphics graphics,Pen pen)
        {
            if (StartPoint.X > EndPoint.X)
            {
                Point point1 = new Point(EndPoint.X, EndPoint.Y);
                Point point2 = new Point(EndPoint.X + 30, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X + 30, EndPoint.Y + 30);

                Point[] points = { point2, point1, point3 };

                graphics.DrawLines(pen, points);
            }
            else if (StartPoint.X < EndPoint.X)
            {
                Point point2 = new Point(EndPoint.X, EndPoint.Y);
                Point point1 = new Point(EndPoint.X - 30, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X - 30, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                graphics.DrawLines(pen, points);

            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                Point point2 = new Point(EndPoint.X, EndPoint.Y);
                Point point1 = new Point(EndPoint.X - 30, EndPoint.Y + 30);
                Point point3 = new Point(EndPoint.X + 30, EndPoint.Y + 30);

                Point[] points = { point1, point2, point3 };

                graphics.DrawLines(pen, points);

            }
            else
            {
                Point point2 = new Point(EndPoint.X, EndPoint.Y);
                Point point1 = new Point(EndPoint.X - 30, EndPoint.Y - 30);
                Point point3 = new Point(EndPoint.X + 30, EndPoint.Y - 30);

                Point[] points = { point1, point2, point3 };

                graphics.DrawLines(pen, points);
            }

            graphics.DrawLines(pen, GetPoints().ToArray());
        }
    }
}
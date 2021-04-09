using System.Drawing;

namespace UMLLizardSoft.Arrows
{
    public class ArrowInheritance : AbstractArrow
    {
        int delta = 30;
        public override void Draw(Graphics graphics, Pen pen)
        {
            SolidBrush solidBrush = new SolidBrush(Color.White);
            DrawingDelta();

            Point point1 = new Point(EndPoint.X, EndPoint.Y);
            Point point2 = new Point(EndPoint.X + delta, EndPoint.Y - delta);
            Point point3 = new Point(EndPoint.X + delta, EndPoint.Y + delta);

            if (StartPoint.X > EndPoint.X)
            {
            }
            else if (StartPoint.X < EndPoint.X)
            {
                point2 = new Point(EndPoint.X - delta, EndPoint.Y - delta);
                point3 = new Point(EndPoint.X - delta, EndPoint.Y + delta);
            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                point2 = new Point(EndPoint.X + delta, EndPoint.Y + delta);
                point3 = new Point(EndPoint.X - delta, EndPoint.Y + delta);
            }
            else
            {
                point2 = new Point(EndPoint.X + delta, EndPoint.Y - delta);
                point3 = new Point(EndPoint.X - delta, EndPoint.Y - delta);
            }
            graphics.DrawLines(pen, GetPoints().ToArray());

            Point[] points = { point1, point2, point3 };
            graphics.FillPolygon(solidBrush, points);
            graphics.DrawPolygon(pen, points);
        }
    }
}
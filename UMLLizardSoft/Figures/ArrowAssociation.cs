using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ArrowAssociation : AbstractArrow

    {
        int delta = 30;

        public override void Draw(Graphics graphics, Pen pen)
        {
            DrawingDelta();

            Point point1 = new Point(EndPoint.X, EndPoint.Y);
            Point point2 = new Point(EndPoint.X + delta, EndPoint.Y - delta);
            Point point3 = new Point(EndPoint.X + delta, EndPoint.Y + delta);

            if (StartPoint.X < EndPoint.X)
            {
                point2 = new Point(EndPoint.X - delta, EndPoint.Y - delta);
                point3 = new Point(EndPoint.X - delta, EndPoint.Y + delta);
            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                point2 = new Point(EndPoint.X + delta, EndPoint.Y + delta);
                point3 = new Point(EndPoint.X - delta, EndPoint.Y + delta);
            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y < EndPoint.Y)
            {
                point2 = new Point(EndPoint.X + delta, EndPoint.Y - delta);
                point3 = new Point(EndPoint.X - delta, EndPoint.Y - delta);
            }

            graphics.DrawLines(pen, GetPoints().ToArray());
            Point[] points = { point2, point1, point3 };
            graphics.DrawLines(pen, points);
        }
    }
}
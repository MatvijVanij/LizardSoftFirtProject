using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ArrowInheritance : AbstractArrow
    {
        int delta = 10;

        public override void Draw(Graphics graphics, Pen pen)
        {
            DrawingDelta();
            SolidBrush solidBrush = new SolidBrush(Color.White);

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

            FigurePen = new Pen(pen.Color, pen.Width);
            graphics.DrawLines(FigurePen, GetPoints().ToArray());
            Point[] points = { point1, point2, point3 };
            graphics.FillPolygon(solidBrush, points);
            graphics.DrawPolygon(FigurePen, points);
        }
    }
}
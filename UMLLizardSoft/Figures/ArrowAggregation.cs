using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ArrowAggregation : AbstractArrow
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            DrawingDelta();
            int delta = 4;
            SolidBrush solidBrush = new SolidBrush(Color.White);

            Point point1 = new Point(EndPoint.X, EndPoint.Y);
            Point point2 = new Point(EndPoint.X + 3 * delta, EndPoint.Y - 2 * delta);
            Point point3 = new Point(EndPoint.X + 3 * delta, EndPoint.Y + 2 * delta);
            Point point4 = new Point(EndPoint.X + 6 * delta, EndPoint.Y);

            if (StartPoint.X < EndPoint.X)
            {
                point2 = new Point(EndPoint.X - 3 * delta, EndPoint.Y - 2 * delta);
                point3 = new Point(EndPoint.X - 3 * delta, EndPoint.Y + 2 * delta);
                point4 = new Point(EndPoint.X - 6 * delta, EndPoint.Y);
            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                point2 = new Point(EndPoint.X + 2 * delta, EndPoint.Y + 3 * delta);
                point3 = new Point(EndPoint.X - 2 * delta, EndPoint.Y + 3 * delta);
                point4 = new Point(EndPoint.X, EndPoint.Y + 6 * delta);
            }
            else if (StartPoint.X == EndPoint.X && StartPoint.Y < EndPoint.Y)
            {
                point2 = new Point(EndPoint.X + 2 * delta, EndPoint.Y - 3 * delta);
                point3 = new Point(EndPoint.X - 2 * delta, EndPoint.Y - 3 * delta);
                point4 = new Point(EndPoint.X, EndPoint.Y - 6 * delta);
            }

            FigurePen = new Pen(pen.Color, pen.Width);
            graphics.DrawLines(FigurePen, GetPoints().ToArray());
            Point[] points = { point1, point2, point4, point3 };
            graphics.FillPolygon(solidBrush, points);
            graphics.DrawPolygon(FigurePen, points);
        }
    }
}
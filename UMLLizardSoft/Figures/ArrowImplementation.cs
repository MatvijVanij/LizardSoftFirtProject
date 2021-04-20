﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace UMLLizardSoft.Figures
{
    public class ArrowImplementation : AbstractArrow
    {
        int delta = 10;

        private ArrowImplementation()
        {
        }

        public static ArrowImplementation Create()
        {
            return new ArrowImplementation();
        }

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
            pen.DashStyle = DashStyle.Dash;
            graphics.DrawLines(pen, GetPoints().ToArray());
            pen.DashStyle = DashStyle.Solid;
            Point[] points = { point1, point2, point3 };
            graphics.FillPolygon(solidBrush, points);
            graphics.DrawPolygon(FigurePen, points);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Figures
{
    public class ClassDiagramStack : ClassDiagramMain
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            _moduls = new List<ClassDiagramMain>();

            FigurePen = new Pen(pen.Color, pen.Width);
            Font myFont = new Font("Arial", 12);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            SolidBrush myBrush = new SolidBrush(pen.Color);
            StringFormat strFormat1 = new StringFormat();

            text1 = string.Empty;
            text2 = string.Empty;
            text3 = string.Empty;

            strFormat1.Alignment = StringAlignment.Near;
            strFormat1.LineAlignment = StringAlignment.Near;
            strFormat1.Trimming = StringTrimming.Character;

            Point point14 = new Point(StartPoint.X, StartPoint.Y);
            Point point15 = new Point(StartPoint.X + width, StartPoint.Y);
            Point point16 = new Point(StartPoint.X + width, StartPoint.Y + 4 * height);
            Point point17 = new Point(StartPoint.X, StartPoint.Y + 4 * height);

            Point[] points1 = { point14, point15, point16, point17 };

            graphics.FillPolygon(solidBrush, points1);

            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, width, height);

            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + height, width, height);

            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y + 2 * height, width, 2 * height);


            foreach (var strText in _listForRect1Text)
            {
                text1 = strText;
            }

            foreach (var strText in _listForRect2Text)
            {
                text2 = strText;
            }

            foreach (var strText in _listForRect3Text)
            {
                text3 = strText;
            }

            graphics.DrawString(text1, myFont, myBrush, StartPoint.X, StartPoint.Y, strFormat1);
            graphics.DrawString(text2, myFont, myBrush, StartPoint.X, StartPoint.Y + height, strFormat1);
            graphics.DrawString(text3, myFont, myBrush, StartPoint.X, StartPoint.Y + 2 * height, strFormat1);

            int delta = 10;

            //graphics.DrawLine(FigurePen, StartPoint.X - delta + width, StartPoint.Y - delta, StartPoint.X - delta + width, StartPoint.Y);
            //graphics.DrawLine(FigurePen, StartPoint.X - delta, StartPoint.Y - delta, StartPoint.X - delta +width, StartPoint.Y - delta);
            //graphics.DrawLine(FigurePen, StartPoint.X - delta, StartPoint.Y - delta, StartPoint.X - delta, StartPoint.Y - delta + 4*height);
            //graphics.DrawLine(FigurePen, StartPoint.X - delta, StartPoint.Y - delta + 4 * height, StartPoint.X, StartPoint.Y - delta + 4 * height);

            Point point1 = new Point(StartPoint.X, StartPoint.Y);
            Point point2 = new Point(StartPoint.X, StartPoint.Y - delta + 4 * height);
            Point point3 = new Point(StartPoint.X - delta, StartPoint.Y - delta + 4 * height);
            Point point4 = new Point(StartPoint.X - delta, StartPoint.Y - delta);
            Point point5 = new Point(StartPoint.X - delta + width, StartPoint.Y - delta);
            Point point6 = new Point(StartPoint.X - delta + width, StartPoint.Y);

            Point[] points = { point1, point2, point3, point4, point5, point6 };

            graphics.DrawPolygon(FigurePen, points);

            Point point7 = new Point(StartPoint.X-delta, StartPoint.Y-delta);
            Point point8 = new Point(StartPoint.X-delta, StartPoint.Y - 2*delta + 4 * height);
            Point point9 = new Point(StartPoint.X - 2*delta, StartPoint.Y - 2*delta + 4 * height);
            Point point10 = new Point(StartPoint.X - 2*delta, StartPoint.Y - 2*delta);
            Point point11 = new Point(StartPoint.X - 2*delta + width, StartPoint.Y - 2*delta);
            Point point12 = new Point(StartPoint.X - 2*delta + width, StartPoint.Y-delta);

            Point[] points2 = { point7, point8, point9, point10, point11, point12 };

            graphics.DrawPolygon(FigurePen, points2);
            //graphics.DrawLine(FigurePen, StartPoint.X - 2*delta + width, StartPoint.Y - 2 * delta, StartPoint.X - 2 * delta + width, StartPoint.Y);
            //graphics.DrawLine(FigurePen, StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta, StartPoint.X - 2 * delta + width, StartPoint.Y - 2 * delta);
            //graphics.DrawLine(FigurePen, StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta, StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta + 4 * height);
            //graphics.DrawLine(FigurePen, StartPoint.X - 2 * delta, StartPoint.Y - 2 * delta + 4 * height, StartPoint.X, StartPoint.Y - 2 * delta + 4 * height);
        }
    }
}

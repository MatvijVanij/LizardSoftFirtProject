using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class ClassDiagram : ClassDiagramMain
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

            Point point1 = new Point(StartPoint.X, StartPoint.Y);
            Point point2 = new Point(StartPoint.X + width, StartPoint.Y);
            Point point3 = new Point(StartPoint.X + width, StartPoint.Y + 4 * height);
            Point point4 = new Point(StartPoint.X, StartPoint.Y + 4 * height);

            Point[] points = { point1, point2, point3, point4 };

            graphics.FillPolygon(solidBrush, points);
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
        }
    }
}
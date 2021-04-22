using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class Rectangle1 : AbstractRectangle
    {

        public override void Draw(Graphics graphics, Pen pen)
        {
            _moduls = new List<Rectangle>();

            FigurePen = new Pen(pen.Color, pen.Width);
            Font myFont = new Font("Arial", 12);
            SolidBrush myBrush = new SolidBrush(pen.Color);
            StringFormat strFormat1 = new StringFormat();

            text1 = string.Empty;
            text2 = string.Empty;
            text3 = string.Empty;

            strFormat1.Alignment = StringAlignment.Near;
            strFormat1.LineAlignment = StringAlignment.Near;
            strFormat1.Trimming = StringTrimming.Character;


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
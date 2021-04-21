using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class Rectangle1 : AbstractRectangle
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            FigurePen = new Pen(pen.Color, pen.Width);
            Font myFont = new Font("Arial", 18);
            SolidBrush myBrush = new SolidBrush(pen.Color);
            StringFormat strFormat1 = new StringFormat();

            text1 = string.Empty;
            text2 = string.Empty;
            text3 = string.Empty;

            //strFormat1.Alignment = StringAlignment.Near;
            //strFormat1.LineAlignment = StringAlignment.Near;
            //strFormat1.Trimming = StringTrimming.Character;

            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, width , height);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y+height, width, height);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y+2*height, width, 2*height);

            //graphics.DrawLine(FigurePen, StartPoint.X, StartPoint.Y + 30, StartPoint.X + width, StartPoint.Y + 30);
            //graphics.DrawLine(FigurePen, StartPoint.X, StartPoint.Y + 60, StartPoint.X + width, StartPoint.Y + 60);


            foreach (var text in _listForRect1Text)
            {
                text1 += text ;
            }

            foreach (var text in _listForRect2Text)
            {
                text2 += text + "\n";
            }

            foreach (var text in _listForRect3Text)
            {
                text3 += text + "\n";
            }
            graphics.DrawString(text1, myFont, myBrush, StartPoint.X, StartPoint.Y, strFormat1);
            graphics.DrawString(text2, myFont, myBrush, StartPoint.X, StartPoint.Y + 30, strFormat1);
            graphics.DrawString(text3, myFont, myBrush, StartPoint.X, StartPoint.Y + 60, strFormat1);
            graphics.DrawString(text3, myFont, myBrush, StartPoint.X, StartPoint.Y + 90, strFormat1);
        }


    }
}
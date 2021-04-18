using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Figures
{
    public class RectangleStack : AbstractRectangle
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            FigurePen = new Pen(pen.Color, pen.Width);
            string str = "Class Name";
            Font myFont = new Font("Arial", 12);
            SolidBrush myBrush = new SolidBrush(pen.Color);

            int height = EndPoint.Y - StartPoint.Y;
            int width = EndPoint.X - StartPoint.X;

            if (StartPoint.X < EndPoint.X && EndPoint.Y > StartPoint.Y + 60 && str.Length + 80 < width)
            {
                graphics.DrawString(str, myFont, myBrush, StartPoint.X, StartPoint.Y);

                graphics.DrawLine(FigurePen, StartPoint.X - 15, StartPoint.Y - 15, StartPoint.X - 15, EndPoint.Y - 15);
                graphics.DrawLine(FigurePen, StartPoint.X - 15, EndPoint.Y - 15, StartPoint.X, EndPoint.Y - 15);
                graphics.DrawLine(FigurePen, StartPoint.X - 15, StartPoint.Y - 15, EndPoint.X - 15, StartPoint.Y - 15);
                graphics.DrawLine(FigurePen, EndPoint.X - 15, StartPoint.Y - 15, EndPoint.X - 15, StartPoint.Y);


                graphics.DrawLine(FigurePen, StartPoint.X - 30, StartPoint.Y - 30, StartPoint.X - 30, EndPoint.Y - 30);
                graphics.DrawLine(FigurePen, StartPoint.X - 30, EndPoint.Y - 30, StartPoint.X - 15, EndPoint.Y - 30);
                graphics.DrawLine(FigurePen, StartPoint.X - 30, StartPoint.Y - 30, EndPoint.X - 30, StartPoint.Y - 30);
                graphics.DrawLine(FigurePen, EndPoint.X - 30, StartPoint.Y - 30, EndPoint.X - 30, StartPoint.Y - 15);

                graphics.DrawLine(FigurePen, StartPoint.X, StartPoint.Y + 30, EndPoint.X, StartPoint.Y + 30);
            }

            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, width, height);
        }
    }
}

using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class Rectangle1 : AbstractRectangle
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            FigurePen = new Pen(pen.Color, pen.Width);
            string str = "Class Name";
            Font myFont = new Font("Arial", 12);
            SolidBrush myBrush = new SolidBrush(pen.Color);

            int height = EndPoint.Y - StartPoint.Y;
            int width = EndPoint.X - StartPoint.X;

            graphics.DrawString(str, myFont, myBrush, StartPoint.X,StartPoint.Y);
            graphics.DrawRectangle(FigurePen, StartPoint.X, StartPoint.Y, width, height);
            graphics.DrawLine(FigurePen, StartPoint.X, StartPoint.Y + 30, EndPoint.X, StartPoint.Y + 30);
            graphics.DrawLine(FigurePen, StartPoint.X, StartPoint.Y + 60, EndPoint.X, StartPoint.Y + 60);
        }
    }
}
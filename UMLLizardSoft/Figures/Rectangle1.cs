using System;
using System.Drawing;


namespace UMLLizardSoft.Figures
{
    public class Rectangle1 : AbstractRectangle
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            string str = "Claas Name";
            Font myFont = new Font("Arial", 16);
            SolidBrush myBrush = new SolidBrush(Color.Black);

            int height = EndPoint.Y - StartPoint.Y;
            int width = EndPoint.X - StartPoint.X;

            graphics.DrawString(str, myFont, myBrush, StartPoint.X,StartPoint.Y);
            graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, width, height);
            graphics.DrawLine(pen, StartPoint.X, StartPoint.Y + 30, EndPoint.X, StartPoint.Y + 30);
        }
    }
}

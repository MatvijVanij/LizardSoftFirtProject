using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Rectangles
{
    public class Rectangle1 : AbstractRectangle
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            int height = EndPoint.Y - StartPoint.Y;
            int width = EndPoint.X - StartPoint.X;

            graphics.DrawRectangle(pen, StartPoint.X, StartPoint.Y, width, height);
        }
    }
}

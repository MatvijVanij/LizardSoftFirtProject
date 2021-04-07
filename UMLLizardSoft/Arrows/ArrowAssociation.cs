using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Arrows
{
    public class ArrowAssociation : AbstractArrow
    {
        public override void Draw(Graphics graphics)
        {
            //double angle = Math.Atan2(x1 - x2, y1 - y2);// Асоциация   

            //Point pointSecond = new Point(x2, y2);
            //Point point1 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(0.4 + angle)), Convert.ToInt32(y2 + 25 * Math.Cos(0.4 + angle)));
            //Point point3 = new Point(Convert.ToInt32(x2 + 25 * Math.Sin(angle - 0.4)), Convert.ToInt32(y2 + 25 * Math.Cos(angle - 0.4)));
            //Point point2 = _pointSecond;
            //Point[] points = { point1, point2, point3 };
            //_graphics.DrawLines(_pen, points);

            graphics.DrawLine(_pen, StartPoint, EndPoint);

            
        }
    }
}

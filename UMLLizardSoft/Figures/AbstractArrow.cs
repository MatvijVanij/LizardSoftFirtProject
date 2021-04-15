﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLLizardSoft.Figures
{
    public class AbstractArrow : AbstractFigure
    {
        public override void Draw(Graphics graphics, Pen pen)
        {

        }
        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            int middle = (StartPoint.X + EndPoint.X) / 2;
            points.Add(new Point(middle, StartPoint.Y));
            points.Add(new Point(middle, EndPoint.Y));
            points.Add(EndPoint);

            return points;
        }

        public void DrawingDelta()
        {
            if (Math.Abs(StartPoint.X - EndPoint.X) < 30)
            {
                EndPoint = new Point(StartPoint.X, EndPoint.Y);
            }
            if (Math.Abs(StartPoint.Y - EndPoint.Y) < 30)
            {
                EndPoint = new Point(EndPoint.X, StartPoint.Y);
            }
        }

        public override void Move(int deltaX, int deltaY)
        {
            //StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            //EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }

        public  bool IsGrabbing(Point point)
        {
            int xMax;
            int xMin;
            int yMax;
            int yMin;

            if (StartPoint.X > EndPoint.X)
            {
                xMax = StartPoint.X;
                xMin = EndPoint.X;
            }
            else
            {
                xMin = StartPoint.X;
                xMax = EndPoint.X;
            }

            if (StartPoint.Y > EndPoint.Y)
            {
                yMax = StartPoint.Y;
                yMin = EndPoint.Y;
            }
            else
            {
                yMin = StartPoint.Y;
                yMax = EndPoint.Y;
            }

            if (point.X <= xMax && point.X >= xMin
             && point.Y <= yMax && point.Y >= yMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace UMLLizardSoft.Figures
{
    public class AbstractArrow : AbstractFigure
    {
        bool isStartPointSelected = false;

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
            //if (Math.Abs(StartPoint.X - EndPoint.X) < 5)
            //{
            //    EndPoint = new Point(StartPoint.X, EndPoint.Y);
            //}
            //if (Math.Abs(StartPoint.Y - EndPoint.Y) < 5)
            //{
            //    EndPoint = new Point(EndPoint.X, StartPoint.Y);
            //}
        }

        public override void Move(int deltaX, int deltaY, Point point)
        {
            if (IsSelected(point))
            {
                if (isStartPointSelected)
                {
                    StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
                }
                else
                {
                    EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
                }
            }
        }

        public override bool IsSelected(Point point)
        {
            if (point.X <= StartPoint.X + 30 && point.X >= StartPoint.X - 30
             && point.Y <= StartPoint.Y + 30 && point.Y >= StartPoint.Y - 30)
            {
                isStartPointSelected = true;
                return true;
            }
            else if (point.X <= EndPoint.X + 30 && point.X >= EndPoint.X - 30
             && point.Y <= EndPoint.Y + 30 && point.Y >= EndPoint.Y - 30)
            {
                isStartPointSelected = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void SaveElementText(string text)
        {
            throw new NotImplementedException();
        }

        public override bool CheckIfTheObjectIsClicked(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
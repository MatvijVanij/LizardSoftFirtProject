using NUnit.Framework;
using System.Drawing;
using UMLLizardSoft.Figures;
using System.Collections;
using System;

namespace UMLLizardSoftTests
{
    public class Tests
    {
        [TestCaseSource(typeof(IsGrabbingSource))]
        public void IsGrabbing_WhenGetPoint_ShouldReturnBool(AbstractFigure absR, Point point, bool expected)
        {
            bool actual = absR.IsSelected(point);
            Assert.AreEqual(expected, actual);
        }
      
    }
    
    public class IsGrabbingSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {
                new Rectangle1 { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(50,50),
                true
            };

            yield return new object[] {
                new Rectangle1 { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(101,101),
                false
            };

            yield return new object[] {
                new Rectangle1 { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(0,0),
                true
            };

            yield return new object[] {
                new ArrowAggregation { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(50,50),
                false
            };

            yield return new object[] {
                new ArrowAggregation { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(31,31),
                false
            };

            yield return new object[] {
                new ArrowAggregation { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(30,30),
                true
            };

            yield return new object[] {
                new ArrowAggregation { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(130,130),
                true
            };

            yield return new object[] {
                new ArrowAggregation { StartPoint = new Point(0, 0),EndPoint = new Point(100,100)},
                new Point(131,131),
                false
            };
        }
    }
}
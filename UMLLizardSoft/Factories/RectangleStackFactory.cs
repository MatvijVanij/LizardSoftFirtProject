using System.Drawing;
using UMLLizardSoft.Figures;


namespace UMLLizardSoft.Factories
{
    class RectangleStackFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            var rectangleStack = RectangleStack.Create();
            rectangleStack.FigurePen = pen;

            return rectangleStack;
        }
    }
}

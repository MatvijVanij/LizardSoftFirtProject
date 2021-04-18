using System.Drawing;
using UMLLizardSoft.Figures;


namespace UMLLizardSoft.Factories
{
    class RectangleStackFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new RectangleStack()
            {
                FigurePen = pen
            };
        }
    }
}

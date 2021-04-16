using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ArrowAggregationFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new ArrowAggregation()
            {
                FigurePen = pen
            };
        }
    }
}
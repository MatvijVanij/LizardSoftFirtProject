using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ArrowAggregationFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            var arrowAggregation = ArrowAggregation.Create();
            arrowAggregation.FigurePen = pen;

            return arrowAggregation;
        }
    }
}
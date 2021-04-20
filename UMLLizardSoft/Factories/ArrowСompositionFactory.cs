using System.Drawing;
using UMLLizardSoft.Figures;
namespace UMLLizardSoft.Factories
{
    public class ArrowСompositionFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            var arrowСomposition = ArrowСomposition.Create();
            arrowСomposition.FigurePen = pen;

            return arrowСomposition;
        }
    }
}
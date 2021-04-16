using System.Drawing;
using UMLLizardSoft.Figures;
namespace UMLLizardSoft.Factories
{
    public class ArrowСompositionFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new ArrowСomposition() 
            { 
                FigurePen = pen
            };
        }
    }
}
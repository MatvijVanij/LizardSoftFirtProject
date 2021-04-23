using System.Drawing;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ClassDiagramFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new ClassDiagram()
            {
                FigurePen = pen
            };
        }
    }
}
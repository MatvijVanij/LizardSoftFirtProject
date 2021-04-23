using System.Drawing;
using UMLLizardSoft.Figures;


namespace UMLLizardSoft.Factories
{
    class ClassDiagramStackFactory : IFactory
    {
        public AbstractFigure Create(Pen pen)
        {
            return new ClassDiagramStack()
            {
                FigurePen = pen
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLLizardSoft.Figures;

namespace UMLLizardSoft.Factories
{
    public class ArrowImplementationFactory : IFactory
    {
        public AbstractFigure Create()
        {
            return new ArrowImplementation();
        }
    }
}

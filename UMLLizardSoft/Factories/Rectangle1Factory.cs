using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLLizardSoft.Figures;
namespace UMLLizardSoft.Factories
{
    public class Rectangle1Factory : IFactory
    {
        public AbstractFigure Create()
        {
            return new Rectangle1();
        }
    }
}

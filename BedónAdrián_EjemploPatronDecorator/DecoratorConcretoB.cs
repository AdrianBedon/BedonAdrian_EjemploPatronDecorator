using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploPatronDecorator
{
    class DecoratorConcretoB : Decorator
    {
        public DecoratorConcretoB(Componente componente) : base(componente)
        {

        }

        public override string Operacion()
        {
            return $"DecoratorConcretoB({base.Operacion()})";
        }
    }
}

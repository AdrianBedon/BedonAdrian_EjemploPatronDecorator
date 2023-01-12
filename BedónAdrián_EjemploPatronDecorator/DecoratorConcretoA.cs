using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploPatronDecorator
{
    class DecoratorConcretoA : Decorator
    {
        public DecoratorConcretoA(Componente componente) : base(componente)
        {

        }

        public override string Operacion()
        {
            return $"DecoratorConcretoA({base.Operacion()})";
        }
    }
}

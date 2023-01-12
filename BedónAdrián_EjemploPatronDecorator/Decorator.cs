using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploPatronDecorator
{
    abstract class Decorator:Componente
    {
        protected Componente _componente;

        public Decorator(Componente componente)
        {
            this._componente = componente;
        }

        public void SetComponente(Componente componente)
        {
            this._componente = componente;
        }

        public override string Operacion()
        {
            if (this._componente != null) 
            {
                return this._componente.Operacion();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}

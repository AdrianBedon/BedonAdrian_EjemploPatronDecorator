using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploPatronDecorator
{
    public class Cliente
    {
        public void ClienteCode(Componente componente)
        {
            Console.WriteLine("RESULTADO: " + componente.Operacion());
        }
    }
}

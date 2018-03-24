using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPolimorfismo
{
    class Promedioprogramacion : Promedio // Hereda de "Promedio"
    {
        // Método para el cálculo de promedio de programación (Sobreescrito)
        public override double calculaPromedio()
        {
            return evaluacion1 * 0.15 + evaluacion2 * 0.3 + evaluacion3 * 0.5 + actitudinal * 0.05;
        }

    }
}

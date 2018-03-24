using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPolimorfismo
{
    class Promedio
    {
        public string estudiante { get; set; }

        public int evaluacion1 { get; set; }

        public int evaluacion2 { get; set; }

        public int evaluacion3 { get; set; }

        public int actitudinal { get; set; }

        // Cálculo de promedio para alumno regular
        public virtual double calculaPromedio()
        {
            return (evaluacion1 + evaluacion2 + evaluacion3 + actitudinal) / 4;
        }

        // Método para la condición del estudiante
        public string determinarCondicion()
        {
            return (calculaPromedio() < 12.5) ? "DESAPROBADO" : "APROBADO";
        }
    }
}

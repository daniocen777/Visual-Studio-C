using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    class Promedio
    {
        public String alumno;
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;

        // Método para determinar la nota más baja
        public int masBaja()
        {
            int menor = int.MaxValue; // Represente el mínimo valor de int 32
            menor = (nota1 < nota2) ? nota1 : nota2;
            menor = (nota3 < menor) ? nota3 : menor;
            menor = (nota4 < menor) ? nota4 : menor;

            return menor;
        }

        // Cañcular promedio de 3 notas
        public double calcularPromedio()
        {
            return (nota1 + nota2 + nota3 + nota4 - masBaja()) / 3;
        }

        // Condición del alumno
        public string asignarCondicion()
        {
            double promedio = calcularPromedio(); // promedio del alumno
            string condicion;
            if (promedio <= 10)
            {
                condicion = "Desaprobado";
            }
            else
            {
                if (promedio > 10 && promedio <= 12)
                {
                    condicion = "Recuperación";
                }
                else
                {
                    condicion = "Aprobado";
                }
            }
            return condicion;
        }

    }
}

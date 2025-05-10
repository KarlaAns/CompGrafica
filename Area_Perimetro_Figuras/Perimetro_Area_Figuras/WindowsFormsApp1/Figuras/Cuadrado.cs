using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Figuras
{
    public class Cuadrado:Figura
    {
        public double Lado { get; set; }
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public override double CalcularArea()
        {
            return Lado * Lado;
        }
        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}

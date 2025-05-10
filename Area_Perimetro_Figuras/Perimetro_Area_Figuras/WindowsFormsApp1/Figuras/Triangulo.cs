using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Figuras
{
    public class Triangulo:Figura
    {
        public double Lado { get; set; }
        public double Altura { get; set; }
        public Triangulo(double lado, double altura)
        {
            Lado = lado;
            Altura = altura;
        }
        public override double CalcularArea()
        {
            return (Lado * Altura) / 2;
        }
        public override double CalcularPerimetro()
        {
            return 3*Lado;
        }
    }

}

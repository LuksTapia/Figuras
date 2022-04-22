using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Circulo : Figura
    {

        private static int pi;
   

        public Circulo(int radioCir) : base (radioCir, pi)
        {
            this.nombre = "circulo";
            Circulo.pi = 3;
        }

        public override int Superficie()
        {
            return (int)Math.Pow(this.lado,2) * Circulo.pi;  
        }



        public override int Perimetro()
        {
            return (2*Circulo.pi)*this.lado;    
        }
    }
}

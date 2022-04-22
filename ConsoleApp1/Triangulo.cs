using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Triangulo : Figura
    {
        private int lado3;

        public Triangulo(int ladoBase, int ladoAltura, int tercerLado) : base(ladoBase, ladoAltura)
        {
            this.nombre = "triángulo";
            this.lado3 = tercerLado;
        }

        public override int Perimetro()
        {
            return this.lado + this.lado3 + this.alto;
        }

        public override int Superficie()
        {
            return (this.lado * this.alto) / 2;
        }

    }

}

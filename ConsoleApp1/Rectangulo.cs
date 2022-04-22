using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo : Figura {

        public Rectangulo(int ladoBase, int ladoAltura) : base(ladoBase,
                                                               ladoAltura)
        {
            this.nombre = "rectángulo";
        
        }

        public override int Superficie()
        {
            return this.alto * this.lado;
        }

        public override int Perimetro()
        {
            return this.alto * 2 + this.lado * 2;
        }







    }
}

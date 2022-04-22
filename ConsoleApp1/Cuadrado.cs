using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Cuadrado : Figura
    {
 

        public Cuadrado(int lado) : base(lado, lado)
        {
            this.nombre = "cuadrado";
           
        }

        public override int Perimetro()
        {
            return this.alto * 4;
        }

        public override int Superficie()
        {
            return (this.alto * this.lado);
        }



    }
}

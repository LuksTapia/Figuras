using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Figura
    {
        protected string nombre;
        protected int lado;
        protected int alto;
   
        public Figura(int lado1, int lado2)
        {

            this.nombre = " ";
            this.lado = lado1;
            this.alto = lado2;
        }

        public String getNombre()
        {
            return this.nombre;
        }


        public virtual int Superficie()
        {
            return 0;
        }

        public virtual int Perimetro()
        {
            return 0;
        }

    }
}

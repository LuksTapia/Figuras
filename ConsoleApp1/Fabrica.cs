using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Fabrica
    {
        private string nombre;
        private List<Figura> lista;


        public Fabrica(string nombre)
        {
            this.nombre = nombre;
            this.lista = new List<Figura>();
        }

        public void agregarFigura()
        {
            int tope = new Random().Next(1, 10); 

            for (int i = 0; i < tope; i++)
            {
                int nFigura = new Random().Next(1, 5);
                int random = new Random().Next(1, 20);

                switch (nFigura)
                {
                    case 1: this.lista.Add(new Circulo(random));
                        break;  
                    case 2: this.lista.Add(new Triangulo(random, random, random));
                        break;
                    case 3: this.lista.Add(new Rectangulo(random, random));
                        break;
                    case 4: this.lista.Add(new Cuadrado(random));
                        break;
                    default:
                        break;
                }

            }  

        }

        public void mostrarLista()
        {
            foreach (Figura figura in this.lista)
            {
                Console.WriteLine("El perimetro del " + figura.getNombre() + " es " + figura.Perimetro());
                Console.WriteLine("La superficie del " + figura.getNombre() + " es " + figura.Superficie());
            }   
        }



    }
}

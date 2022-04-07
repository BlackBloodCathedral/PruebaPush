using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCuadrado
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double ancho, alto, area, perimetro;

               void parametrosArea() {


                Console.WriteLine("Digite el ancho del rectangulo en centimetros: "); // Preguntamos por el ancho
                ancho = double.Parse(Console.ReadLine()); // Guardamos la informacion del ancho

                Console.WriteLine("\nDigite el alto del rectangulo en centimetros: "); // Preguntamos por el alto
                alto = double.Parse(Console.ReadLine()); // Guardamos la informacion del alto


                
                perimetro = (ancho + alto) * 2; // Operacion para calcular perimetro

                Console.WriteLine("\nEl area del rectangulo es {0} cm²", area);
                Console.WriteLine("\nEl perimetro del rectangulo es {0} cm", perimetro);

                

            }


        }
    }
}

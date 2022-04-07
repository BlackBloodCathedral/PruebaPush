using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDosNoGrafica
{
    public class CLS_Triangulo
    {

        double baseTriangulo = 0;
        double AlturaTriangulo = 0;
        double area = 0;

        public double AreaTotalTriangulo() {
        
        Console.Clear();
        
        Console.WriteLine("Digite la base del triangulo");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite la altura del triangulo");
            AlturaTriangulo = Convert.ToDouble(Console.ReadLine());

            area = baseTriangulo * AlturaTriangulo / 2;

        Console.WriteLine("El area del triangulo es {0} centimetros cuadrados\n", area);

    

            return area;

            

            }

        



    }
}

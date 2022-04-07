using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDosNoGrafica
{
    internal class CLS_gRADOS
    {

        double grados = 0;
        double operacion = 0;  
        string resultado = "";  

        public string calculo() {

            Console.Clear();
            Console.WriteLine("Digite los grados Celsius que desea convertir: ");
            grados = Convert.ToDouble(Console.ReadLine());

            operacion = (grados * 1.8) + 32;
            Convert.ToString(operacion);

            resultado = "El resultado en grados Fahrenheit es: " + Convert.ToString(operacion);

            Console.WriteLine(resultado);   


            return resultado;




        }

    }
}

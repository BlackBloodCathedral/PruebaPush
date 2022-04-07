using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoreLabSemana2
{
    internal class Operaciones
    {

        public void Suma() {

            string v_entrada = "";

            int num1 = 0, num2 = 0, resultado = 0;

            //Leer cadena
            Console.WriteLine("Digite su nombre"); //Pregunta el nombre
            v_entrada = Console.ReadLine(); // Lee el nombre y lo almacena en la variable

            Console.WriteLine("Hola {0}, como estas?", v_entrada); // Muestra el texto y utiliza el nombre almacenado en la variable

            //Leemos dos valores y los sumamos

            Console.WriteLine("Digita un numero entero");
            v_entrada = Console.ReadLine();

            num1 = Convert.ToInt32(v_entrada);

            Console.WriteLine("Digita otro numero entero");
            v_entrada = Console.ReadLine();

            num2 = Convert.ToInt32(v_entrada);


            //Vamos a dar el resultado

            resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma es: " + resultado);


        }


        public void SumaDouble()
        {

            string v_entrada = "";

            double num1 = 0, num2 = 0, resultado = 0;

            //Leer cadena
            Console.WriteLine("Digite su nombre"); //Pregunta el nombre
            v_entrada = Console.ReadLine(); // Lee el nombre y lo almacena en la variable

            Console.WriteLine("Hola {0}, como estas?", v_entrada); // Muestra el texto y utiliza el nombre almacenado en la variable

            //Leemos dos valores y los sumamos

            Console.WriteLine("Digita un numero entero");
            v_entrada = Console.ReadLine();

            num1 = Convert.ToDouble(v_entrada);

            Console.WriteLine("Digita otro numero entero");
            v_entrada = Console.ReadLine();

            num2 = Convert.ToDouble(v_entrada);


            //Vamos a dar el resultado

            resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma es: " + resultado);


        }



    }
}

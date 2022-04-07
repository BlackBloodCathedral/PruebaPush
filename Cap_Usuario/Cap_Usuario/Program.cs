using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap_Procesos;

namespace Cap_Usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cls_Suma sumar = new Cls_Suma();

            string v_entrada;
            int num1, num2; 

            Console.WriteLine("Ingrese el primer valor: ");
            v_entrada = Console.ReadLine();
            num1 = Convert.ToInt32(v_entrada);

            Console.WriteLine("Ingrese el segundo valor: ");
            v_entrada = Console.ReadLine();
            num2 = Convert.ToInt32(v_entrada);

            int respuesta = sumar.m_sumar(num1, num2);

            Console.WriteLine("El resultado es {0}", respuesta);
        }
    }
}

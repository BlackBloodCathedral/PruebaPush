using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDosNoGrafica
{
    internal class Edades
    {
        int edadUsuarioUno = 0;
        int edadUsuarioDos = 0;
        String resultado = "";

        public string coincidenEdades()
        {
            Console.Clear();
            
            Console.WriteLine("Digite la edad del primer usuario");
            edadUsuarioUno = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite la edad del primer usuario");
            edadUsuarioDos = Convert.ToInt16(Console.ReadLine());

            if (edadUsuarioUno.Equals(edadUsuarioDos))
            {

                resultado = "True";


            }
            else {

                resultado = "False";

            }






            return Convert.ToString(resultado);   
        }

    }
}

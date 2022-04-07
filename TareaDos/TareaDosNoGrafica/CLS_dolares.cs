using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDosNoGrafica
{
    public class CLS_dolares
    {


            double Dolars = 0;
            double Colons = 0;
            double result = 0;

            public double ConversorDolares()
            {

                Console.Clear();

                Console.WriteLine("Digite la cantidad de dolares");
                Dolars = Convert.ToDouble(Console.ReadLine());

                result = Dolars * 639;

                Console.WriteLine("{1} son {0} al tipo de cambio de 639 colones", result, Dolars);



                return result;



            }

        }

    }


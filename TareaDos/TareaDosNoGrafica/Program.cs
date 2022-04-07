using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDosNoGrafica
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

             bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Seleciona una opcion utilizando los numeros:");
                Console.WriteLine("1) Area de un triangulo");
                Console.WriteLine("2) Convertir dolares a colones");
                Console.WriteLine("3) Convertir dolares a colones");
                Console.WriteLine("4) Convertir dolares a colones");
                Console.WriteLine("5) Convertir dolares a colones");
                Console.WriteLine("6) Convertir dolares a colones");
                Console.WriteLine("7) Convertir dolares a colones");
                Console.WriteLine("8) Convertir dolares a colones");
                Console.WriteLine("9) Convertir dolares a colones");
                Console.WriteLine("10) Convertir dolares a colones");
                Console.WriteLine("11) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                    CLS_Triangulo areaDeUnTriangulo = new CLS_Triangulo();
                        areaDeUnTriangulo.AreaTotalTriangulo();
                        return false;
                    case "2":
                        CLS_dolares conversor = new CLS_dolares();
                        conversor.ConversorDolares();
                        return false;
                    case "3":
                        Edades edades = new Edades();   
                        edades.coincidenEdades();
                        return false;

                    case "4":
                        CLS_gRADOS GRADOS = new CLS_gRADOS();
                        GRADOS.calculo();
                        return false;

                    case "5":
                        return false;

                    case "6":
                        return false;

                    case "7":
                        return false;

                    case "8":
                        return false;

                    case "9":
                        return false;

                    case "10":
                        return false;

                    case "0":
                        return false;

                    default:
                        return true;
                }
            }





        }
    }
}

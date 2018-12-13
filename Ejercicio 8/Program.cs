using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            System.Console.WriteLine("ingrese un año");
            string texto = System.Console.ReadLine();
            num1 = int.Parse(texto);
            if (num1 % 400 == 0)
            {
                System.Console.WriteLine("El año es" + num1 + " es bisiesto");
            }

            else
            if (num1 % 4 == 0 && num1 % 100 != 0)
            {
                System.Console.WriteLine("el año " + num1 + "  es bisiesto");
            }

            else
            {
                System.Console.WriteLine("el año " + num1 + "  no es bisiesto");

            }
            System.Console.ReadKey();
        }
        return
        {
                }
                }
                }
 
        
        


    

       
  


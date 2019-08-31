using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2
{

    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 28.08.19
    //-------Luis Adrián Alfonzo Morán-------

    class Ejercicio1Guia2
        {
            static void Main(string[] args)
            {
                //Base
                string name;

                //Proceso
                Console.WriteLine("¿Cúal es su nombre completo?");
                name = Console.ReadLine();
                name = name.Replace('A', '#').Replace('E', '%').Replace('I', '$').Replace('O', '?').Replace('U', '*');
                name = name.Replace('a', '#').Replace('e', '%').Replace('i', '$').Replace('o', '?').Replace('u', '*');
                Console.WriteLine(name);
                Console.WriteLine("Presiona [SPACE] para continuar");
                Console.ReadKey();
            }
        }
    }
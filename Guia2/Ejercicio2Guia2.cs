using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2

//------------------UNICAES------------------
//---Facultad de Ingenería y Arquitectura---
//--INGENIERÍA EN DESARROLLO DE SOFTWARE--
//-Última fecha de modificación: 28.08.19
//-------Luis Adrián Alfonzo Morán-------

{
    class Ejercicio2Guia2
    {
        static void Main(string[] args)
        {
            //Base
            string nameProducto;
            int how;
            decimal moneyIncial;
            decimal subtotal;
            decimal iva;
            decimal totPay;

            //Consulta
            Console.WriteLine("-----Tiendita del Señor Yisus-----");
            Console.Write("¿Cuál es el producto a comprar?");
            nameProducto = Console.ReadLine();
            Console.Write("Precio: $");
            moneyIncial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Cantidad: ");
            how = Convert.ToInt32(Console.ReadLine());

            //Procesos
            subtotal = moneyIncial * how;
            iva = subtotal * 0.13m;
            totPay = subtotal + iva;

            //Mostrar
            Console.Clear();
            Console.WriteLine("Nombre del producto: {0}", nameProducto);
            Console.WriteLine("Precio del producto: ${0}", moneyIncial);
            Console.WriteLine("Cantidad: {0}", how);
            Console.WriteLine("Subtotal: ${0}", subtotal);
            Console.WriteLine("IVA: ${0}", iva);
            Console.WriteLine("Total a pagar: ${0}", totPay);
            Console.ReadKey();

        }
    }
}


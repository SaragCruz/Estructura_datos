using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int agua = 0;
            int luz = 0;
            int gas = 0;
            int est = 0;
            double precioTA = 0;
            double precioTL = 0;
            double precioTG = 0;
            double precioT = 0;
            double DESCUENTO1 = 0.20;
            double DESCUENTO2 = 0.15;
            double DESCUENTO3 = 0.09;

            Console.WriteLine("Digite el valor del recibo del agua");
            agua = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del recibo de la luz");
            luz = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del recibo del gas");
            gas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el estrato al cual pertenece");
            est = int.Parse(Console.ReadLine());


            if (est == 1)
            {
                precioTA = agua - (agua * DESCUENTO1);
                precioTL = luz - (luz * DESCUENTO1);
                precioTG = gas - (gas * DESCUENTO1);
                precioT = precioTA + precioTL + precioTG;
            }

            if (est == 2)
            {
                precioTA = agua - (agua * DESCUENTO2);
                precioTL = luz - (luz * DESCUENTO2);
                precioTG = gas - (gas * DESCUENTO2);
                precioT = precioTA + precioTL + precioTG;
            }
            if (est == 3)
            {
                precioTA = agua - (agua * DESCUENTO3);
                precioTL = luz - (luz * DESCUENTO3);
                precioTG = gas - (gas * DESCUENTO3);
                precioT = precioTA + precioTL + precioTG;
            }
            Console.WriteLine("El costo a pagar por el recibo del agua es {0}:", precioTA);
            Console.WriteLine("El costo a pagar por el recibo de la luz es {0}:", precioTL);
            Console.WriteLine("El costo a pagar por el recibo del gas es {0}:", precioTG);
            Console.WriteLine("El costo a pagar por todos los recibos es {0}:", precioT);
        }
    }
}
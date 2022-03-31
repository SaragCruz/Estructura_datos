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
            int TAMAÑOFIL = 3;
            int TAMAÑOCOL = 3;

            int[,] matriz1 = new int[TAMAÑOFIL, TAMAÑOCOL];
            for (int fil1 = 0; fil1 < 1; fil1++)
            {
                for (int col1 = 0; col1 < TAMAÑOCOL; col1++)
                {
                    Console.Write($"Ingrese el costo del recibo del agua [{fil1 + 1},{col1 + 1}] de la matriz #1: ");
                    matriz1[fil1, col1] = int.Parse(System.Console.ReadLine());
                }

            }
            for (int fil1 = 1; fil1 < 2; fil1++)
            {
                for (int col1 = 0; col1 < TAMAÑOCOL; col1++)
                {
                    Console.Write($"Ingrese el costo del recibo de la luz [{fil1 + 1},{col1 + 1}] de la matriz #1: ");
                    matriz1[fil1, col1] = int.Parse(System.Console.ReadLine());
                }

            }
            for (int fil1 = 2; fil1 < 3; fil1++)
            {
                for (int col1 = 0; col1 < TAMAÑOCOL; col1++)
                {
                    Console.Write($"Ingrese el costo del recibo de el gas [{fil1 + 1},{col1 + 1}] de la matriz #1: ");
                    matriz1[fil1, col1] = int.Parse(System.Console.ReadLine());
                }

            }
            for (int fil1 = 0; fil1 < matriz1.GetLength(0); fil1++)
            {
                for (int col1 = 0; col1 < matriz1.GetLength(1); col1++)
                {
                    Console.Write("    [" + matriz1[fil1, col1] + "] ");
                }
                Console.WriteLine();
            }
            int estfa1,estfa2,estfa3 = 0; 
            int agua1,agua2,agua3,luz1,luz2,luz3,gas1,gas2,gas3 = 0;
            agua1 = matriz1[0, 0]; agua2 = matriz1[0, 1]; agua3 = matriz1[0, 2];
            luz1 = matriz1[1, 0]; luz2 = matriz1[1, 1]; luz3 = matriz1[1, 2];
            gas1 = matriz1[2, 0]; gas2 = matriz1[2, 1]; gas3 = matriz1[2, 2];
            double preciota1 = 0; double preciota2 = 0; double preciota3 = 0;
            double preciotl1 = 0; double preciotl2 = 0; double preciotl3 = 0;
            double preciotg1 = 0; double preciotg2 = 0; double preciotg3 = 0;
            double preciot1 = 0; double preciot2 = 0; double preciot3 = 0;
            double DESCUENTO1 = 0.20; double DESCUENTO2 = 0.15; double DESCUENTO3 = 0.09;

            Console.WriteLine("El estrato de la familia 1 es: ");
            estfa1 = int.Parse(Console.ReadLine());

            if (estfa1 == 1)
            {
                preciota1 = agua1 - (agua1 * DESCUENTO1);
                preciotl1 = luz1 - (luz1 * DESCUENTO1);
                preciotg1 = gas1 - (gas1 * DESCUENTO1);
                preciot1 = preciota1 + preciotl1 + preciotg1;
            }
            if (estfa1 == 2)
            {
                preciota1 = agua1 - (agua1 * DESCUENTO2);
                preciotl1 = luz1 - (luz1 * DESCUENTO2);
                preciotg1 = gas1 - (gas1 * DESCUENTO2);
                preciot1 = preciota1 + preciotl1 + preciotg1;
            }
            if (estfa1 == 3)
            {
                preciota1 = agua1 - (agua1 * DESCUENTO3);
                preciotl1 = luz1 - (luz1 * DESCUENTO2);
                preciotg1 = gas1 - (gas1 * DESCUENTO2);
                preciot1 = preciota1 + preciotl1 + preciotg1;
            }
            Console.WriteLine("El costo a pagar por el recibo del agua de la familia 1 es: {0}", preciota1);
            Console.WriteLine("El costo a pagar por el recibo de la luz de la familia 1 es: {0}:", preciotl1);
            Console.WriteLine("El costo a pagar por el recibo de el gas de la familia 1 es: {0}:", preciotg1);
            Console.WriteLine("El costo a pagar por todos los recibos de la familia 1 es: {0}:", preciot1);

            Console.WriteLine("El estrato de la familia 2 es: ");
            estfa2 = int.Parse(Console.ReadLine());

            if (estfa2 == 1)
            {
                preciota2 = agua2 - (agua2 * DESCUENTO1);
                preciotl2 = luz2 - (luz2 * DESCUENTO1);
                preciotg2 = gas2 - (gas2 * DESCUENTO1);
                preciot2 = preciota2 + preciotl2 + preciotg2;
            }
            if (estfa2 == 2)
            {
                preciota2 = agua2 - (agua2 * DESCUENTO2);
                preciotl2 = luz2 - (luz2 * DESCUENTO2);
                preciotg2 = gas2 - (gas2 * DESCUENTO2);
                preciot2 = preciota2 + preciotl2 + preciotg2;
            }
            if (estfa2 == 3)
            {
                preciota2 = agua2 - (agua2 * DESCUENTO3);
                preciotl2 = luz2 - (luz2 * DESCUENTO3);
                preciotg2 = gas2 - (gas2 * DESCUENTO3);
                preciot2 = preciota2 + preciotl2 + preciotg2;
            }
            Console.WriteLine("El costo a pagar por el recibo del agua de la familia 2 es: {0}", preciota2);
            Console.WriteLine("El costo a pagar por el recibo de la luz de la familia 2 es: {0}:", preciotl2);
            Console.WriteLine("El costo a pagar por el recibo de el gas de la familia 2 es: {0}:", preciotg2);
            Console.WriteLine("El costo a pagar por todos los recibos de la familia 2 es: {0}:", preciot2);

            Console.WriteLine("El estrato de la familia 3 es: ");
            estfa3 = int.Parse(Console.ReadLine());

            if (estfa3 == 1)
            {
                preciota3 = agua3 - (agua3 * DESCUENTO1);
                preciotl3 = luz3 - (luz3 * DESCUENTO1);
                preciotg3 = gas3 - (gas3 * DESCUENTO1);
                preciot3 = preciota3 + preciotl3 + preciotg3;
            }
            if (estfa3 == 2)
            {
                preciota3 = agua3 - (agua3 * DESCUENTO2);
                preciotl3 = luz3 - (luz3 * DESCUENTO2);
                preciotg3 = gas3 - (gas3 * DESCUENTO2);
                preciot3 = preciota3 + preciotl3 + preciotg3;
            }
            if (estfa3 == 3)
            {
                preciota3 = agua3 - (agua3 * DESCUENTO3);
                preciotl3 = luz3 - (luz3 * DESCUENTO3);
                preciotg3 = gas3 - (gas3 * DESCUENTO3);
                preciot3 = preciota3 + preciotl3 + preciotg3;
            }
            Console.WriteLine("El costo a pagar por el recibo del agua de la familia 3 es: {0}", preciota3);
            Console.WriteLine("El costo a pagar por el recibo de la luz de la familia 3 es: {0}:", preciotl3);
            Console.WriteLine("El costo a pagar por el recibo de el gas de la familia 3 es: {0}:", preciotg3);
            Console.WriteLine("El costo a pagar por todos los recibos de la familia 3 es: {0}:", preciot3);
        }
    }
}

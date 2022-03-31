using System;
using System.Collections;
namespace AplicacionBase
{
    class alfabeto
    {
        //int[,] num;
        

        static void Main(string[] args)
        {
            int[,] num;
            int valor = 0;
            int CANTIDADFILAS = 3;
            int CANTIDADCOLUMNAS = 6;
 
            num = new int[CANTIDADFILAS,CANTIDADCOLUMNAS];

            for (int m = 0; m < CANTIDADFILAS; m++)
            {

                for (int o = 0; o < CANTIDADCOLUMNAS; o++)

                {

                    Console.WriteLine("digite los valores");
                    num[m,o]= int.Parse(System.Console.ReadLine());
                }
                Console.WriteLine();
            }

            int numero = num[0, 0];
            for (int m = 0; m < CANTIDADFILAS; m++)
            {
                for (int o = 0; o < CANTIDADCOLUMNAS; o++)
                {
                    Console.WriteLine(num[o,m]);
                }
            }
                
        }
       
    }
}
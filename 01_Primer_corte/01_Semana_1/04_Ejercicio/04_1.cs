using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int MULTIPLICA = 3, DIVIDE = 2, SUMA = 1;
            int NumDeseado = 0, Resultado = 0;

            System.Console.WriteLine("Dijite el número para verificar la conjetura de Collatz. "); 
            NumDeseado=int.Parse(System.Console.ReadLine());
            while (NumDeseado>1)
            { 
                
                if (NumDeseado % 2 == 0)
                {
                    Resultado = NumDeseado / DIVIDE;  
                }
                else 
                {
                    Resultado = (NumDeseado * MULTIPLICA) + SUMA;
                }
                System.Console.WriteLine("La secuencia es: {0}" ,Resultado);
                if (Resultado==1)
                {
                    NumDeseado = Resultado;
                }
                else
                {
                    NumDeseado = Resultado;
                }
            }
            if (NumDeseado<1)
            {
                System.Console.WriteLine("Número invalido.");
            }
        }
    }
}
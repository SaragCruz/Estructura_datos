using System;
using System.Collections;

namespace Ejercicio11
{
    class CambioColas
    {
        static void Main(string[] args)
        {
            Queue C1=new Queue();
            Queue C2=new Queue();
            Queue C3=new Queue();
            Console.Write("Digite el tamaño de las colas:  ");
            int TamCola=int.Parse(Console.ReadLine());
            for(int j=0;j<TamCola;j++){
                Console.Write($"Digite el elemento {j+1} de la cola No°1: ");
                int Valor1=int.Parse(Console.ReadLine());
                C1.Enqueue(Valor1);
            }Console.WriteLine();
            for(int e=0;e<TamCola;e++){ 
                Console.Write($"Digite el elemento {e+1} de la cola No° 2: ");
                int Valor2=int.Parse(Console.ReadLine());
                C2.Enqueue(Valor2);
            }

            Console.WriteLine("\nLa cola No° 1 es: ");
            while (C1.Count > 0)
            {
                int Co = 0;
                Co = (int)C1.Dequeue();
                Console.WriteLine(Co);
                C3.Enqueue(Co);
            }

            Console.WriteLine("\nLa cola No° 2 es: ");
            while (C2.Count > 0)
            {
                int Co1 = 0;
                Co1 = (int)C2.Dequeue();
                Console.WriteLine(Co1);
                C1.Enqueue(Co1);
            }

            for(int j=0;j<TamCola;j++){
                int Val = 0;
                Val = (int)C3.Dequeue();
                C2.Enqueue(Val);
            }

            Console.WriteLine("\nLa cola No°1 resultante es: ");
            foreach (int number in C1)
            {
                Console.WriteLine(" {0} ", number);
            }

            Console.WriteLine("\nLa cola No°2 resultante es: ");
            foreach (int number in C2)
            {
                Console.WriteLine(" {0} ", number);
            }

        }
    }
}
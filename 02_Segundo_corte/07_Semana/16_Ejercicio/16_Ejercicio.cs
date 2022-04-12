using System;
using System.Collections;

namespace Ejercicio12
{
    class ColaInvertida
    {
        static void Main(string[] args)
        {
            Queue<float> C1=new Queue<float>();
            Stack<float> P=new Stack<float>();
            Console.Write("Digite el tamaño de la cola:  ");
            int TamCola=int.Parse(Console.ReadLine());
            for(int j=0;j<TamCola;j++){
                Console.Write($"Digite el elemento {j+1} de la cola: ");
                float Valor1=float.Parse(Console.ReadLine());
                C1.Enqueue(Valor1);
            }

            Console.WriteLine("\nLa cola No° 1 es: ");
            while (C1.Count > 0)
            {
                float Co = 0;
                Co = (float)C1.Dequeue();
                Console.WriteLine(" {0} ", Co);
                P.Push(Co);
            }

            for(int j=0;j<TamCola;j++){
                float Val = 0;
                Val = (float)P.Pop();
                C1.Enqueue(Val);
            }

            Console.WriteLine("\nLa cola No°1 resultante es: ");
            foreach (float number in C1)
            {
                Console.WriteLine(" {0} ", number);
            }
        }
    }
}
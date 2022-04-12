using System;
using System.Collections;

namespace Ejercicio13
{
    class ColaPilaSinInvertir
    {
        static void Main(string[] args)
        {
            Queue<float> C=new Queue<float>();
            Stack<float> P=new Stack<float>();
            Console.Write("Digite el tamaño de la cola:  ");
            int TamCola=int.Parse(Console.ReadLine());
            for(int j=0;j<TamCola;j++){
                Console.Write($"Digite el elemento {j+1} de la cola: ");
                float Valor1=float.Parse(Console.ReadLine());
                C.Enqueue(Valor1);
            }

            Console.WriteLine("\nLa cola No° 1 es: ");
            while (C.Count > 0)
            {
                float Co = 0;
                Co = (float)C.Dequeue();
                Console.WriteLine(" {0} ", Co);
                P.Push(Co);
            }

            for(int j=0;j<TamCola;j++){
                float Val = 0;
                Val = (float)P.Pop();
                C.Enqueue(Val);
            }

            for(int j=0;j<TamCola;j++){
                float Re = 0;
                Re = (float)C.Dequeue();
                P.Push(Re);
            }

            Console.WriteLine("\nLa pila resultante es: ");
            foreach (float number in P)
            {
                Console.WriteLine(" {0} ", number);
            }
        }
    }
}
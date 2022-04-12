using System;
using System.Collections;

namespace Ejercicio10
{
    class Pilas
    {
        static void Main(string[] args)
        {
            Stack<float> Pila1 = new Stack<float>();
            Stack Pila2 = new Stack();

            Console.Write("Digite el tamaño de la pila:  ");
            int TamPila = int.Parse(Console.ReadLine());
            for (int j = 0; j < TamPila; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la pila #1: ");
                float Valor1 = float.Parse(Console.ReadLine());
                Pila1.Push(Valor1);
            }

            Console.WriteLine("\nLa pila #1 es: ");
            while (Pila1.Count > 0)
            {
                float Co = 0;
                Co = (float)Pila1.Pop();
                Console.WriteLine(Co);
                Pila2.Push(Co);
            }

            for (int j = 0; j < TamPila; j++)
            {
                float Val = 0;
                Val = (float)Pila2.Pop();
                Pila2.Push(Val);
            }

            Console.WriteLine("\nLa pila final #1 es: ");
            foreach (float number in Pila2)
            {
                Console.WriteLine("{0} ", number);
            }
        }
    }
}
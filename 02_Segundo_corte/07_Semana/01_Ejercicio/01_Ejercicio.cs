using System;
using System.Collections;

namespace Ejercicio1
{
    class Ordencolas
    {
        static void Main(string[] args)
        {

            Queue ColaC1 = new Queue();
            Queue ColaC2 = new Queue();
            Stack Pila = new Stack();
            int numeros = 0;
            int[] vector = new int[numeros];

            Console.WriteLine("digite los numeros de la cola: ");
            while (true)
            {
                numeros = int.Parse(Console.ReadLine());

                 if (numeros == 0)
                {
                    Console.WriteLine("se termino la secuencia por que digito 0");
                    break;
                }

                ColaC1.Enqueue(numeros);   
            }

            ArrayList Array = new ArrayList();
            Console.WriteLine("\nLa cola digitada es: ");
            while (ColaC1.Count > 0) 
            {
                int Co = 0;
                Co = (int)ColaC1.Dequeue();
                Console.WriteLine("[" + Co + "]");
                Array.Add(Co);
            }
            Array.Sort();

            Console.WriteLine("\nLa cola ordenada es: ");
            foreach(int j in Array){
                ColaC1.Enqueue(j);
                Console.WriteLine("[" + ColaC1.Dequeue() + "]");
            }
        }
    } 
}
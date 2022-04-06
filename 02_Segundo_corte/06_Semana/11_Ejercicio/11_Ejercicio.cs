using System;
using System.Collections;

namespace Ejercicio11
{
    class Ejercicio7
    {
        static void Mostrar(ArrayList Arreglo)
        {
            foreach (float n in Arreglo)
            {
                Console.WriteLine(" {0} ", n);
            }
            Console.WriteLine("\n--------------");
        }
        static void Main(string[] args)
        {
            ArrayList Lista1 = new ArrayList();
            ArrayList Lista2 = new ArrayList();
            Console.Write("Digite el tamaño del arraylist: ");
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Digite el elemento {j + 1} de la lista #1: ");
                float Valor = float.Parse(Console.ReadLine());
                Lista1.Insert(j, Valor);
                Lista2.Insert(j, Valor);
            }

            Console.WriteLine("La lista #1 es: ");
            Mostrar(Lista1);
            Console.WriteLine("La lista #2 es: ");
            Mostrar(Lista2); 
        }
    }
}
using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos las dos listas pedidas en el ejercicio

            Console.WriteLine("lista número 1: ");

            ArrayList Lista1 = new ArrayList();

            Lista1.Add(1);
            Lista1.Add(3);
            Lista1.Add(5);
            Lista1.Add(7);
            Lista1.Add(9);

            imprime(Lista1);

            Console.WriteLine("lista número 2: ");

            ArrayList Lista2 = new ArrayList();

            Lista2.Add(2);
            Lista2.Add(4);
            Lista2.Add(6);
            Lista2.Add(8);
            Lista2.Add(10);

            imprime(Lista2);

            Console.WriteLine("Lista número 3: ");
            ArrayList Lista3 = new ArrayList();

            Lista3.Add(3);
            Lista3.Add(3);
            Lista3.Add(3);
            Lista3.Add(3);
            Lista3.Add(3);

            imprime(Lista3);

            Console.WriteLine("Lista número 4: ");
            ArrayList Lista4 = new ArrayList();

            Lista4.Add(4);
            Lista4.Add(4);
            Lista4.Add(4);
            Lista4.Add(4);
            Lista4.Add(4);

            imprime(Lista4);

            Console.WriteLine("La concanetacion de las cuatro listas es: ");
            Lista1.AddRange(Lista2);
            Lista1.AddRange(Lista3);
            Lista1.AddRange(Lista4);
            imprime(Lista1);
        }
        static void imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0},", n);
            Console.WriteLine("\n-----------");
        }
    }
}
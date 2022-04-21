using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            int TAMAÑO_VECTOR = 10;
            int numero = 0;

            ArrayList lista = new ArrayList();
            for (int i = 0; i < TAMAÑO_VECTOR; i++)
            {
                Console.WriteLine($"lista numero ");
                numero = int.Parse(Console.ReadLine());
                lista.Insert(i, numero);
            }
            
            lista.Sort();
            Console.WriteLine("\n-----------");
            imprime(lista);
        }
        static void imprime(ArrayList arreglo)
        {

            foreach (int n in arreglo)
                Console.WriteLine(n);
            Console.WriteLine("\n-----------");
           
        }

    }
}
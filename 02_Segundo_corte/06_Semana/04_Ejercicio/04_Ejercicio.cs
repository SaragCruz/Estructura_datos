using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lista numero 1");
            ArrayList Lista1 = new ArrayList();
            Lista1.Add(1);
            Lista1.Add(2);
            Lista1.Add(3);
            Lista1.Add(4);
            Lista1.Add(5);
            Lista1.Add(6);
            Lista1.Add(7);
            Lista1.Add(8);
            Lista1.Add(9);
            Lista1.Add(10);
            imprime(Lista1);
            Console.WriteLine("lista numero 2");
            ArrayList Lista2 = new ArrayList();
            Lista2.Add(1);
            Lista2.Add(2);
            Lista2.Add(3);
            Lista2.Add(4);
            Lista2.Add(5);
            Lista2.Add(6);
            Lista2.Add(7);
            Lista2.Add(8);
            Lista2.Add(9);
            Lista2.Add(10);
            imprime(Lista2);
            Console.WriteLine("lista numero 3");
            ArrayList Lista3 = new ArrayList();
            Lista3.Add(1);
            Lista3.Add(2);
            Lista3.Add(3);
            Lista3.Add(4);
            Lista3.Add(5);
            Lista3.Add(6);
            Lista3.Add(7);
            Lista3.Add(8);
            Lista3.Add(9);
            Lista3.Add(10);
            imprime(Lista3);
            Console.WriteLine("lista numero 4");
            ArrayList Lista4 = new ArrayList();
            Lista4.Add(1);
            Lista4.Add(2);
            Lista4.Add(3);
            Lista4.Add(4);
            Lista4.Add(5);
            Lista4.Add(6);
            Lista4.Add(7);
            Lista4.Add(8);
            Lista4.Add(9);
            Lista4.Add(10);
            imprime(Lista4);
            Console.WriteLine("lista numero 5");
            ArrayList Lista5 = new ArrayList();
            Lista5.Add(1);
            Lista5.Add(2);
            Lista5.Add(3);
            Lista5.Add(4);
            Lista5.Add(5);
            Lista5.Add(6);
            Lista5.Add(7);
            Lista5.Add(8);
            Lista5.Add(9);
            Lista5.Add(10);
            imprime(Lista5);
            Console.WriteLine("lista numero 6");
            ArrayList Lista6= new ArrayList();
            Lista6.Add(1);
            Lista6.Add(2);
            Lista6.Add(3);
            Lista6.Add(4);
            Lista6.Add(5);
            Lista6.Add(6);
            Lista6.Add(7);
            Lista6.Add(8);
            Lista6.Add(9);
            Lista6.Add(10);

            imprime(Lista6);
            Lista1.AddRange(Lista2);
            Lista1.AddRange(Lista3);
            Lista1.AddRange(Lista4);
            Lista1.AddRange(Lista5);
            Lista1.AddRange(Lista6);
            imprime(Lista1);



            static void imprime(ArrayList arreglo)
            {
                foreach (int n in arreglo)
                    Console.WriteLine("{0},", n);
                Console.WriteLine("\n---------");
            }
        }
    }
}
using System;
using System.Collections;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();

            Console.WriteLine("La lista es: ");
            Lista.Add(2);
            Lista.Add(10);
            Lista.Add(18);
            Lista.Add(20);
            Lista.Add(45);
            Lista.Add(62);
            Lista.Add(80);
            Lista.Add(100);
            ImprimirLista(Lista);

            Console.WriteLine("Los resultados de los  valores elevados al cuadrado son: ");
            CuadradosLista(Lista);

            Console.WriteLine("La suma de los valores elevados al cuadrado es: ");
            SumatoriaLista(Lista);
        }
        static void ImprimirLista(ArrayList arreglo){
            foreach (int n in arreglo)
                Console.Write($" {n}");
            Console.WriteLine("\n-----------");
        }
        
        static void CuadradosLista(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write($" { n * n},");
            Console.WriteLine("\n-----------");
        }

        static void SumatoriaLista(ArrayList arreglo)
        {
            int resultado = 0;
            foreach (int n in arreglo)
                resultado = resultado + (n * n);
            Console.Write($" {resultado}");
            Console.WriteLine("\n-----------");
        }
    }
}
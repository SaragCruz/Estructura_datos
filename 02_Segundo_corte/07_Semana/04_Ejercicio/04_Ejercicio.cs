using System;
using System.Collections;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lista numero 1");
            Stack<float> pila1 = new Stack<float>();
            pila1.Push(1);
            pila1.Push(2);
            pila1.Push(3);
            pila1.Push(4);
            pila1.Push(5);
            pila1.Push(6);
            pila1.Push(7);
            pila1.Push(8);
            pila1.Push(9);
            pila1.Push(10);
            
            
            Console.WriteLine("lista numero 2");
            Stack<float> pila2 = new Stack<float>();
            pila2.Push(1);
            pila2.Push(2);
            pila2.Push(3);
            pila2.Push(4);
            pila2.Push(5);
            pila2.Push(6);
            pila2.Push(7);
            pila2.Push(8);
            pila2.Push(9);
            pila2.Push(10);
            Console.WriteLine("\n Pila 1:");
            Console.WriteLine();
            Stack<float> Pila3 = new Stack<float>();
            while (pila2.Count > 0)
            {
                float Co = 0;
                Co = (float)pila2.Pop();
                Console.Write(" [" + Co + "]");
                Pila3.Push(Co);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\n pila 2: ");
            Console.WriteLine();

            while (pila1.Count > 0)
            {
                float Co = 0;
                Co = (float)pila1.Pop();
                Console.Write(" [" + Co + "]");
                Pila3.Push(Co);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\n concatenacion \n");

            while (Pila3.Count > 0)
            {
                float Co = 0;
                Co = (float)Pila3.Pop();
                Console.WriteLine(" [" + Co + "]");
            }
            Console.WriteLine();
        }
    }
}
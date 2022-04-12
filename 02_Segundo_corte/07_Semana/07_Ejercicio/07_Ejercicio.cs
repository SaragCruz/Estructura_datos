using System;
using System.Collections;

namespace CSharp_Shell
{
    class program
    {
        static void Main(string[] args)
        {
            Stack<float> Pila1 = new Stack<float>();
            Pila1.Push(10);
            Pila1.Push(11);
            Pila1.Push(12);
            Pila1.Push(13);
            Pila1.Push(14);
            Pila1.Push(15);
            Pila1.Push(16);
            Pila1.Push(17);
            Pila1.Push(18);
            Pila1.Push(19);

            Stack<float> Pila2 = new Stack<float>();
            Pila2.Push(20);
            Pila2.Push(21);
            Pila2.Push(22);
            Pila2.Push(23);
            Pila2.Push(24);
            Pila2.Push(25);
            Pila2.Push(26);
            Pila2.Push(27);
            Pila2.Push(28);
            Pila2.Push(29);

            Console.WriteLine("\n Pila 1:");
            Console.WriteLine();
            Stack<float> Pila3 = new Stack<float>();
            while (Pila2.Count > 0)
            {
                float Co = 0;
                Co = (float)Pila2.Pop();
                Console.Write(" [" + Co + "]");
                Pila3.Push(Co);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\n pila 2: ");
            Console.WriteLine();

            while (Pila1.Count > 0)
            {
                float Co = 0;
                Co = (float)Pila1.Pop();
                Console.Write(" [" + Co + "]");
                Pila3.Push(Co);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\n La pila creada: \n");

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

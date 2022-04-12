using System;
using System.Collections;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue ColaC1 = new Queue();
            Queue ColaC2 = new Queue();
            Queue ColaC3 = new Queue();

            int[] matriz1 = {1,2,3,4,5,6,7,8,9,10};
            ColaC1.Enqueue(1);
            ColaC1.Enqueue(2);
            ColaC1.Enqueue(3);
            ColaC1.Enqueue(4);
            ColaC1.Enqueue(5);
            ColaC1.Enqueue(6);
            ColaC1.Enqueue(7);
            ColaC1.Enqueue(8);
            ColaC1.Enqueue(9);
            ColaC1.Enqueue(10);

            int[] matriz2 = {11,12,13,14,15,16,17,18,19,20};
            ColaC2.Enqueue(11);
            ColaC2.Enqueue(12);
            ColaC2.Enqueue(12);
            ColaC2.Enqueue(14);
            ColaC2.Enqueue(15);
            ColaC2.Enqueue(16);
            ColaC2.Enqueue(17);
            ColaC2.Enqueue(18);
            ColaC2.Enqueue(19);
            ColaC2.Enqueue(20);

            int[] matriz3 = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            ColaC3.Enqueue(21);
            ColaC3.Enqueue(22);
            ColaC3.Enqueue(23);
            ColaC3.Enqueue(24);
            ColaC3.Enqueue(25);
            ColaC3.Enqueue(26);
            ColaC3.Enqueue(27);
            ColaC3.Enqueue(28);
            ColaC3.Enqueue(29);
            ColaC3.Enqueue(30);

            Console.WriteLine();
            Console.WriteLine("\n Cola 1:");
            Console.WriteLine();

            while (ColaC1.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC1.Dequeue();
                Console.Write(" [" + Co + "]");
            }
            Console.WriteLine();
            Console.WriteLine("\n Cola 2:");
            Console.WriteLine();

            while (ColaC2.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC2.Dequeue();
                Console.Write(" [" + Co + "]");
            }
            Console.WriteLine();
            Console.WriteLine("\n Cola 3:");
            Console.WriteLine();

            while (ColaC3.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC3.Dequeue();
                Console.Write(" [" + Co + "]");
            }
            Console.WriteLine();

            Console.WriteLine("\n Los números de la matriz son: \n");
            for (int j = 0; j < matriz1.Length; j++)
            {
                Console.Write($"[{matriz1[j]* matriz1[j]}]");
            }
            Console.WriteLine();
            for (int j = 0; j < matriz2.Length; j++)
            {
                Console.Write($"[{matriz2[j] * matriz2[j]}]");
            }
            Console.WriteLine();
            for (int j = 0; j < matriz3.Length; j++)
            {
                Console.Write($"[{matriz3[j] * matriz3[j]}]");
            }
            Console.WriteLine();
        }
    }
}
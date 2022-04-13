using System;
using System.Collections;



namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Co = 0;
            int co = 0;
            int resultado = 0;
            int multi = 0;

            Queue ColaC3 = new Queue();

            Queue ColaC1 = new Queue();
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
            

            Queue ColaC2 = new Queue();

            ColaC2.Enqueue(1);
            ColaC2.Enqueue(2);
            ColaC2.Enqueue(3);
            ColaC2.Enqueue(4);
            ColaC2.Enqueue(5);
            ColaC2.Enqueue(6);
            ColaC2.Enqueue(7);
            ColaC2.Enqueue(8);
            ColaC2.Enqueue(9);
            ColaC2.Enqueue(10);


            while (ColaC1.Count > 0)

            {
                
                Co = (int)ColaC1.Dequeue();
                Console.Write($" cola1 :[" + Co + "]");
                co = (int)ColaC2.Dequeue();
                Console.Write($" cola2 :[" + co + "]");
                Console.WriteLine("\n------");
                Console.WriteLine($"{co*Co}");
                resultado = resultado + (Co * co);
                Console.Write($" Tota: {resultado}");
                Console.WriteLine("\n-------");
            }
        }
    }
}
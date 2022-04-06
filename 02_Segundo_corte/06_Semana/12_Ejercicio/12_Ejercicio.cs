using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int[] array2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Console.WriteLine("Los números del array #1 son: ");
            for (int j = 0; j < array1.Length; j++)
            {
                Console.WriteLine($"Posición: {j} : {array1[j]}");
            }

            Console.WriteLine("Los números del array #2 son: ");
            for (int j = 0; j < array2.Length; j++) 
            { 
                Console.WriteLine($"Posición: {j} : {array2[j]}"); 
            }        
            Console.WriteLine("Los números generados nuevamente en el array #2 son: ");
            array1.CopyTo(array2, 0);
            for (int j = 0; j < array2.Length; j++)
            {
                Console.WriteLine($"Posición:{j} : {array1[j]}");
            }
            Console.ReadKey();

        }
    }
}

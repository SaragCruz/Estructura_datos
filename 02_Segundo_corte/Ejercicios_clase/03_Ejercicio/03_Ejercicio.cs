 using System;

namespace aplicacionBase
{

    class PrimeraMatriz
    {
        int[,] Matriz = new int[3, 3];
        int FILAS_MATRIZ = 3;
        int COLUMNAS_MATRIZ = 3;

        public void CargarMatriz()
        {
            for (int f = 0; f < FILAS_MATRIZ; f++)
            {
                for (int c = 0; c < COLUMNAS_MATRIZ; c++)
                {
                    Console.Write($"Ingrese el elemento {f + 1}, {c + 1} de la matriz: ");
                    Matriz[f, c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("\nLa matriz resultante es");

            for (int f = 0; f < FILAS_MATRIZ; f++)
            {
                for (int c = 0; c < COLUMNAS_MATRIZ; c++)
                {
                    Console.Write("    [" + Matriz[f, c] + "] ");
                }
                Console.WriteLine();
            }
        }
        public void Imprimirdiagonal()
        {
            Console.WriteLine("\nLa diagonal principal resultante es");

            for (int i = 0; i < FILAS_MATRIZ; i++)
            {
                for (int j = 0; j < COLUMNAS_MATRIZ; j++)
                {

                    if (i == j) { Console.Write(Matriz[i, j]); }
                    else { Console.Write("  "); }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void Imprimirdiagonalinversa()
        {
            Console.WriteLine("\nLa diagonal inversa resultante es");

            for (int i = 0; i < FILAS_MATRIZ; i++)
            {
                for (int j = 0; j < COLUMNAS_MATRIZ; j++)
                {

                    if (j + i == COLUMNAS_MATRIZ-1) { Console.Write(Matriz[i, j]); }
                    else { Console.Write("  "); }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            PrimeraMatriz matriz = new PrimeraMatriz();
            matriz.CargarMatriz();
            matriz.ImprimirMatriz();
            matriz.Imprimirdiagonal();
            matriz.Imprimirdiagonalinversa();
        }
    }
}
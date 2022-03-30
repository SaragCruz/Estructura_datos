using System;
namespace AplicacionBase
{
    class program
    {
        public void cargarmatriz()
        {
            int TAMAÑOFIL = 5; 
            int TAMAÑOCOL = 5;

            int[,] matriz1 = new int[TAMAÑOFIL, TAMAÑOCOL];
            for (int fil2 = 0; fil2 < TAMAÑOFIL; fil2++)
            {
                for (int col2 = 0; col2 < TAMAÑOCOL; col2++)
                {
                    Console.Write($"Ingrese el elemento [{fil2 + 1},{col2 + 1}] de la matriz #2: ");
                    matriz1[fil2, col2] = int.Parse(System.Console.ReadLine());
                }
            }
            int[,] matrizT = new int[TAMAÑOFIL, TAMAÑOCOL];
            for (int fil2 = 0; fil2 < TAMAÑOFIL; fil2++)
            {
                for (int col2 = 0; col2 < TAMAÑOCOL; col2++)
                {
                    matrizT[fil2, col2] = matriz1[col2, fil2];
                }
            }
            string resultado = "La matriz resultante #1 es: \n";
            for (int fil2 = 0; fil2 < TAMAÑOFIL; fil2++)
            {
                for (int col2 = 0; col2 < TAMAÑOCOL; col2++)
                {
                    resultado = resultado + ("    [" + matriz1[fil2, col2] + "] ");
                }
                resultado = resultado + "\n";
            }
            resultado = resultado + " La matriz transpuesta de la matriz #1 es: \n";
            for (int fil2 = 0; fil2 < TAMAÑOFIL; fil2++)
            {
                for (int col2 = 0; col2 < TAMAÑOCOL; col2++)
                {
                    resultado = resultado + ("    [" + matrizT[fil2, col2] + "] ");
                }
                resultado = resultado + "\n";
            }
            Console.Write(resultado);

        }
        static void Main(String[] args)
        {
            program Program = new program();
            Program.cargarmatriz();
        }
    }
}
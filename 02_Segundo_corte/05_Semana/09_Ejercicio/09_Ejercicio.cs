using System;
using System.Collections;

namespace Ejercicio9
{
    class Marco1y0
    {
        private int[,] Marco;
        int CANTIDAD_FILAS = 5;
        int CANTIDAD_COLUMNAS = 15;

        public void CargarMatriz()
        {
            Marco = new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];

            for (int f = 0; f < Marco.GetLength(0); f++)
            {
                if(f==0 || f==4){
                    for (int c = 0; c < Marco.GetLength(1); c++)
                    {
                        Console.Write("1 ");
                    }
                }else{
                    for (int c = 0; c < Marco.GetLength(1); c++)
                    {
                        if(c==0 || c==14){
                        Console.Write("1 ");
                        }else{
                        Console.Write("0 ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Marco1y0 op = new Marco1y0();
            op.CargarMatriz();
        }
    }
}

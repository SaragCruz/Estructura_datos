using System;
using System.Collections;

namespace Ejer11
{
    class Paises
    {
        private string [,] MatrizPais;
        int CANTIDAD_FILAS=4;
        int CANTIDAD_COLUMNAS=4;
        public void CargaMatrizPaises()
        {
            MatrizPais=new string[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];

            for(int f=0;f<CANTIDAD_FILAS;f++){
                for(int c=0;c<CANTIDAD_COLUMNAS;c++){
                    if(c==0){
                        Console.Write("Digite el país:");
                    }
                    else{
                        Console.Write("Digite las ciudades:");
                    }
                }
            }
        }
        public void Imprimir()
        {
            Console.Write("País: ");
            for(int f=0;f<CANTIDAD_FILAS;f++){
                Console.Write("Ciudades: ");
                for(int c=0;c<CANTIDAD_COLUMNAS;c++){
                    Console.Write(" "+MatrizPais[f,c]+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Paises op=new Paises();
            op.CargaMatrizPaises();
            op.Imprimir();
        }
    }

}
using System;
using System.Collections;

namespace Ejercicio10
{
    class ValorMaxyMin
    {
        private int [,] Matriz;
        int CANTIDAD_FILAS=6;
        int CANTIDAD_COLUMNAS=10;
        public void CargaMatriz()
        {
            Matriz=new int[CANTIDAD_FILAS, CANTIDAD_COLUMNAS];
            Random al=new Random();

            for(int f=0;f<Matriz.GetLength(0);f++){
                for(int c=0;c<Matriz.GetLength(1);c++){
                   Matriz[f,c]= al.Next(0, 1001);
                }  
            }         
        }
        public void Evaluar(){
            int Mayor=Matriz[0,0];
            int Fila=0, Colum=0;
            for(int f=0;f<Matriz.GetLength(0);f++){
                for(int c=0;c<Matriz.GetLength(1);c++){
                    if(Matriz[f,c]>Mayor){
                        Mayor=Matriz[f,c];
                        Fila=f+1;
                        Colum=c+1;                       
                    }
                }
            }
            Console.WriteLine($"\nEl número mayor es: {Mayor} y está en la posición {Fila},{Colum}");

            int Menor=Matriz[0,0];
            for(int f=0;f<Matriz.GetLength(0);f++){
                for(int c=0;c<Matriz.GetLength(1);c++){
                    if(Matriz[f,c]<Menor){
                        Menor=Matriz[f,c];
                        Fila=f+1;
                        Colum=c+1;                       
                    }
                }
            }
            Console.WriteLine($"\nEl número menor es: {Menor} y está en la posición {Fila},{Colum}");
        }
        public void MostrarTodo()
        {
            for(int f=0;f<Matriz.GetLength(0);f++){
                for(int c=0;c<Matriz.GetLength(1);c++){
                    Console.Write(" "+Matriz[f,c]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ValorMaxyMin op=new ValorMaxyMin();
            op.CargaMatriz();
            op.MostrarTodo();
            op.Evaluar();
        }
    }
}

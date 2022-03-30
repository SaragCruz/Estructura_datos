using System;
using System.Collections;

namespace Ejercicio10
{
    class ValorMaxyMin
    {
        private int [,] KmRecorridos;
        private String [] Nombres;
        private int [] TotalKm;
        int Cantidad_Filas=0;
        int CANTIDAD_COLUMNAS=5;
        public void CargaDatos()
        {
            Console.Write("Digite la cantidad de empleados: ");
            Cantidad_Filas=int.Parse(Console.ReadLine());
            Nombres=new string[Cantidad_Filas];
            for(int v=0;v<Nombres.Length;v++){
                Console.Write("Digite el nombre del empleado: ");
                Nombres[v]=Console.ReadLine();
            }Console.WriteLine();

            TotalKm=new int[Cantidad_Filas];
            KmRecorridos=new int[Cantidad_Filas, CANTIDAD_COLUMNAS];
            for(int f=0;f<KmRecorridos.GetLength(0);f++){
                int SumKm=0;
                for(int c=0;c<KmRecorridos.GetLength(1);c++){
                   Console.Write($"Digite los kilometros recorridos por {Nombres[f]} el día {c+1}: ");
                   KmRecorridos[f,c]=int.Parse(Console.ReadLine());
                   SumKm+=KmRecorridos[f,c];
                } Console.WriteLine();
                TotalKm[f]= SumKm;
            }         
        }
        public async void MostrarTodo()
        {
            Console.WriteLine("\nEmpleados: ");
            for(int v=0;v<Nombres.Length;v++){
                Console.WriteLine(Nombres[v]);
            }
            Console.WriteLine("\nTabla de Kilometros: ");
            for(int f=0;f<KmRecorridos.GetLength(0);f++){
                for(int c=0;c<KmRecorridos.GetLength(1);c++){
                    Console.Write(" "+KmRecorridos[f,c]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTotal Kilometros: ");
            for(int t=0;t<TotalKm.Length;t++){
                Console.WriteLine(TotalKm[t]);
            }Console.WriteLine();
            for(int m=0;m<TotalKm.Length;m++){
                Console.WriteLine($"El conductor {Nombres[m]} a manejado {TotalKm[m]} Km.");
            }
        }
        static void Main(string[] args)
        {
            ValorMaxyMin op=new ValorMaxyMin();
            op.CargaDatos();
            op.MostrarTodo();
        }
    }
}

using System;
using System.Collections;

namespace Ejercicio10
{
    class Ejercicio9
    {
        static void Mostrar(ArrayList Arreglo)
        {
            foreach(int n in Arreglo){
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------");
        }
        static void Main(string[] args)
        {
            ArrayList Lista1=new ArrayList();
            Console.Write("Digite el tamaño del arraylist: ");
            int m=int.Parse(Console.ReadLine());
             for(int j=0;j<m;j++){
                Console.Write($"Digite el elemento {j+1}: ");
                int Valor=int.Parse(Console.ReadLine());
                Lista1.Insert(j,Valor);
            }
            Mostrar(Lista1);
        }
    }
}
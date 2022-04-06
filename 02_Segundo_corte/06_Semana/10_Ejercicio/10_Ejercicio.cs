using System;
using System.Collections;

namespace Ejercicio10
{
    class Ejercicio9
    {
        static void Mostrar(ArrayList Arreglo)
        {
            foreach(float n in Arreglo){
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
                float Valor=float.Parse(Console.ReadLine());
                Lista1.Insert(j,Valor);
            }
            Mostrar(Lista1);
            Lista1.Reverse();
            Mostrar(Lista1);
        }
    }
}
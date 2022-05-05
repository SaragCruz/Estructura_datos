using System;

namespace Ejercicio16
{
    class Metodos
    {
        static void Main(string[] args)
        {
            string Algo="Hello, my name is Juan, Hello, How are you?";
            string[] Vec = Algo.Split(' ');
            string[] Vec2=Algo.Split(' ', ',');

            Console.WriteLine(Algo);
            foreach(string vec in Vec){
                Console.WriteLine(vec);
            }
            Console.WriteLine("-------------");
            foreach(string vec1 in Vec2){
                Console.WriteLine(vec1);
            }
        }
    } 
}
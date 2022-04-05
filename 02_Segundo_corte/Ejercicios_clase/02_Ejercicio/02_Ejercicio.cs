using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Vector2
{
    class program
    {
        int[] Vector;
        int tamañovector = 0;
        public void CargarVector()
        {
            Console.Write("Ingrese la longitud del Vector: ");
            tamañovector = int.Parse(System.Console.ReadLine());
            Vector = new int[tamañovector];

            for (int f = 0; f < Vector.Length; f++)
            {
                Console.Write($"Ingrese el elemento {f + 1} del Vector: ");

                Vector[f] = int.Parse(System.Console.ReadLine());
            }
        }

        public void Mostrar()
        {
            for (int f = 0; f < Vector[0]; f++)
            {
                Console.WriteLine("En el indice " + f + " Esta el número " + Vector[0]);

            }
            for (int f = 0; f < Vector[0]; f++)
            {
                Console.WriteLine("En el indice " + tamañovector + " Esta el número " + Vector[tamañovector-1]);

            }
        }
        static void Main(string[] args)

        {
            program Program = new program();
            Program.CargarVector();
            Program.Mostrar();
        }
    }
}

using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Vector2
{
    class program
    {
        double[] altura;

        public void Operaciones()
        {

            int cantidad_personas;
            double suma = 0, altura1 = 0, prom = 0;


            Console.WriteLine("Ingrese la cantidad de personas :");
            cantidad_personas = int.Parse(System.Console.ReadLine());
            double[] altura = new double[cantidad_personas];

            for (int f = 0; f < cantidad_personas; f++)
            {
                Console.WriteLine("ingrese la altura ");
                altura[f] = double.Parse(System.Console.ReadLine());
                suma = suma+altura[f];
                prom = suma / cantidad_personas;
            }
            Console.WriteLine("la media es " + prom);
            for (int i = 0; i < cantidad_personas; i++)
            Array.Sort(altura);

            Console.WriteLine("El número menor es: " + altura[0]);
            Console.WriteLine("El número mayor es: " + altura[cantidad_personas - 1]);

        }

        static void Main(string[] args)

        {
            program Program = new program();

            Program.Operaciones();
        }

    }
}
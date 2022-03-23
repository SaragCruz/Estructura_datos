using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Vector2
{
    class program
    {
        int[] Vector;
        int TAMAÑOVECTOR = 100;
        public void CargarVector()
        {
            Vector = new int[TAMAÑOVECTOR];

            for (int f = 0; f < Vector.Length; f++)
            {
                Vector[f] = f+1;
            }
        }
        public void Mostrar()
        {
            for (int f = 0; f < Vector.Length; f++)
            {
                Console.WriteLine(" En el indice " + f + " Esta el número " + Vector[f]);

            }
        }
        public void Operacion()
        {
            double resultadosum = 0;
            double resultadomed = 0;
            for (int f = 0; f < Vector.Length; f++)
            {
                resultadosum = resultadosum + Vector[f];
                Console.WriteLine("La suma del vector es = " + resultadosum);

                resultadomed = resultadosum / Vector[f];
                Console.WriteLine("La media del vector es = " + resultadomed);
            }

        }
        static void Main(string[] args)

        {
            program Program = new program();
            Program.CargarVector();
            Program.Mostrar();
            Program.Operacion();
        }
    }
}
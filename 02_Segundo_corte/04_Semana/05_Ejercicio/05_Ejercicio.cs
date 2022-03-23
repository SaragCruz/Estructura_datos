using System;
using System.Collections;



namespace AplicacionBase
{
    class alfabeto
    {

        static void Main(string[] args)
        {

            ArrayList abecedario = new ArrayList(27);

            for (int i = -1; i <= 0; i++)


            abecedario.Add('A'); abecedario.Add('B'); abecedario.Add('C'); abecedario.Add('D'); abecedario.Add('E'); abecedario.Add('F'); abecedario.Add('G'); abecedario.Add('H'); abecedario.Add('I'); abecedario.Add('J'); abecedario.Add('K'); abecedario.Add('L'); abecedario.Add('M'); abecedario.Add('N'); abecedario.Add('O'); abecedario.Add('P'); abecedario.Add('Q');
            abecedario.Add('R'); abecedario.Add('S'); abecedario.Add('T'); abecedario.Add('U'); abecedario.Add('V'); abecedario.Add('W'); abecedario.Add('X'); abecedario.Add('Y'); abecedario.Add('Z');
            {
               
                string secuencia = "";
                int final;
                do
                {

                    Console.WriteLine("digite un numero del 1 al 27 ", (abecedario.Add));

                    final = int.Parse(System.Console.ReadLine());

                    if (final > 0 && final >= abecedario.Add(-1))
                    {
                        Console.WriteLine("la secuencia no se puede realizar");
                    }
                    else
                    {
                        if (final != -1)
                        {
                            secuencia += abecedario[final];
                           
                        }
                    }
                    Console.WriteLine("las letras son{0}", secuencia);
                }
                while (final != -1);
            }

        }

    }

}
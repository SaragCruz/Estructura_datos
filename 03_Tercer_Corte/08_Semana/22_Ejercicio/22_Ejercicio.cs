using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;

class ABC
{

    string CaracterDefinitivo(char caracter, int tiempos)
    {
        StringBuilder constructora = new StringBuilder("");

        for (int counter = 0; counter < tiempos; counter++)

        {
            constructora.Append(caracter);
        }

        return constructora.ToString();
    }

}
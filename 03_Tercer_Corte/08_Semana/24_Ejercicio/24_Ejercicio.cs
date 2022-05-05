using System;
using System.Text;
using System.Collections;
using System.Globalization; 

namespace Ejercicio24
{
    public class Ejercicio24
    {
        public System.Text.StringBuilder AppendFormat (string formato, object? argrs0);

        // Obliga a la cadena devuelta a crear un formato compuesto, que contiene 0 o mas elementos 

    public static void Main()
    {
      int    var1   = 111;
      float  var2   = 2.22F;
      string var3   = "abcd";
      object[] var4 = {3, 4.4, 'X'};

      Console.WriteLine();
      Console.WriteLine("El metodo es:");
      sb.AppendFormat("1) {0}", var1);
      Show(sb);
      sb.AppendFormat("2) {0}, {1}", var1, var2);
      Show(sb);
      sb.AppendFormat("3) {0}, {1}, {2}", var1, var2, var3);
      Show(sb);
      sb.AppendFormat("4) {0}, {1}, {2}", var4);
      Show(sb);
      CultureInfo si = new CultureInfo("es-ES", true);
      sb.AppendFormat(si, "5) {0}", var2);
      Show(sb);
    }

    public static void Show(StringBuilder sis)
       {
           Console.WriteLine(sis.ToString());
           sb.Length = 0;
       }

    } // Se utiliza la funcion de formato compuesto, convierte el valor de un objeto en StringBuilder
}
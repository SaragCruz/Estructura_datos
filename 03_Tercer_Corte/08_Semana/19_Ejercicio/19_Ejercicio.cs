using System;
  
class ABC {
      
      
    public static void Main()
    {
        string j1 = " ABC";
        string j2 = " ABC ";
  

        Console.WriteLine("Antes");
        Console.WriteLine(j1);
        Console.WriteLine(j2);
  
        Console.WriteLine("");
  

        Console.WriteLine("Despues:");
        Console.WriteLine(j1.Trim());
        Console.WriteLine(j2.Trim());
    }
}
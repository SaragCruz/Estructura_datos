namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // esta metodo se utiliza para colocar letras,numeros o caracteres dentro de la oracion desde la letra que queremos
            //que aparezca 
            // En este ejercicio se colocan dos asteriscos en la palabra "con"
            // En este ejercicio se coloca la palabra aqui en la palabra "ejercicio"
            string palabra = "Ejercicio con metodo Insert";

            Console.WriteLine(palabra);
            Console.WriteLine(palabra.Insert (12 ,"**")) ;
            Console.WriteLine(palabra.Insert(4, "AQUI"));
            Console.ReadLine();
           
        }
    }
}
using System;

namespace AplicacionBase
{
    public class Persona
    {

        protected string nombre;
        protected string correo;
        protected string telefono;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string Correo
        {
            set
            {
                correo = value;
            }
            get
            {
                return correo;
            }
        }
        public string Telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return telefono;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Correo:" + Correo);
            Console.WriteLine("Telefono:" + Telefono);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Sara";
            persona1.Correo = "sara@gmail.com";
            persona1.Telefono = "3206362192";
            Console.WriteLine("Los datos de la persona son:");
            persona1.Imprimir();

            Console.ReadKey();
        }
    }
}
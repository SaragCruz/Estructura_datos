using System;

namespace AplicacionBase
{
    public class Producto
    {

        protected string nombre;
        protected string descripcion;
        protected float precio; 

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

        public string Descripcion
        {
            set
            {
                descripcion = value;
            }
            get
            {
                return descripcion;
            }
        }
        public float Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Descripcion:" + Descripcion);
            Console.WriteLine("Precio:" + Precio);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto();
            producto1.Nombre = "Gaseosa";
            producto1.Descripcion = "Bebida fria";
            producto1.Precio = 2500;
            Console.WriteLine("Los datos del producto #1 son:");
            producto1.Imprimir();
            Console.WriteLine(); 

            Producto producto2 = new Producto();
            producto2.Nombre = "Granizado";
            producto2.Descripcion = "Bebida helada";
            producto2.Precio = 8000;
            Console.WriteLine("Los datos del producto #2 son:");
            producto2.Imprimir();
            Console.WriteLine();

            Producto producto3 = new Producto();
            producto3.Nombre = "Cafe";
            producto3.Descripcion = "Bebida caliente";
            producto3.Precio = 1000;
            Console.WriteLine("Los datos del producto #3 son:");
            producto3.Imprimir();

            Console.ReadKey();
        }
    }
}
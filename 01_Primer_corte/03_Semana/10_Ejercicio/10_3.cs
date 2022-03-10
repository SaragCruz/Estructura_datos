using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Shell
{
    public static class Program
    {
        public static void Main()
        {
            int CanVac = 0, VacInicial = 1000, Lugar = 0, VacResultante1 = 0, VacResultante = 0,
            VacResultante2 = 0, VacResultante3 = 0;
            string Cerrar = "no";

            while (Cerrar == "no")
            {
                Console.WriteLine("Digitar el lugar.");
                Console.WriteLine("1- lugar 1.");
                Console.WriteLine("2- lugar 2.");
                Console.WriteLine("3- lugar 3.");
                Lugar = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el número de vacunas aplicadas.");
                CanVac = int.Parse(Console.ReadLine());

                switch (Lugar)
                {
                    case 1:
                        VacResultante1 += CanVac;

                        if (VacResultante1 > 800)
                        {
                            Console.WriteLine("Inventario bajo, debe pedir vacunas");
                        }
                        else
                        {
                            VacResultante = VacInicial - VacResultante1;
                            Console.WriteLine($"Las vacunas que quedan son: {VacResultante}");

                        }
                        break;
                    case 2:
                        VacResultante2 += CanVac;

                        if (VacResultante2 > 800)
                        {
                            Console.WriteLine("Inventario bajo, debe pedir vacunas");
                        }
                        else
                        {
                            VacResultante = VacInicial - VacResultante2;
                            Console.WriteLine($"Las vacunas que quedan son: {VacResultante}");

                        }
                        break;
                    case 3:
                        VacResultante3 += CanVac;

                        if (VacResultante3 > 800)
                        {
                            Console.WriteLine("Inventario bajo, debe pedir vacunas");
                        }
                        else
                        {
                            VacResultante = VacInicial - VacResultante3;
                            Console.WriteLine($"Las vacunas que quedan son: {VacResultante}");

                        }
                        break;
                }
                Console.WriteLine("Desea cerrar el programa: (si o no)");
                Cerrar = Console.ReadLine();
            }
            Console.WriteLine($"Las vacunas aplicadas en el lugar uno fueron: {VacResultante1}");
            Console.WriteLine($"Las vacunas aplicadas en el lugar dos fueron: {VacResultante2}");
            Console.WriteLine($"Las.vacunas aplicadas en el lugar tres fueron {VacResultante3}");
        }
    }
}
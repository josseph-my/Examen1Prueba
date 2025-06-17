using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    internal class Program
    {
        static string[][] Español = new string[5][];
        static string[][] Matematicas = new string[5][];
        static string[][] Ciencias = new string[5][];
        static string[][] Sociales = new string[5][];

        static void IniciarEspañol()
        {
            for (int dia = 0; dia < Español.Length; dia++)
            {
                Español[dia] = new string[3];
            }
        }
        static void IniciarMatematica()

        {
            for (int dia = 0; dia < Matematicas.Length; dia++)
            {
                Español[dia] = new string[3];
            }
        }
        static void IniciarCiencias()
        {
            for (int dia = 0; dia < Ciencias.Length; dia++)
            {
                Ciencias[dia] = new string[3];
            }
        }
        static void IniciarSociales()
        {
            for (int dia = 0; dia < Sociales.Length; dia++)
            {
                Sociales[dia] = new string[3];
            }
        }

        static void Menu()

        {
            Console.WriteLine("**** Menú de Opciones ****");
            Console.WriteLine("1. Registrar Estudiante");
            Console.WriteLine("2. Eliminar Estudiante");
            Console.WriteLine("3. Consultar Estudiante");
            Console.WriteLine("\nDigiete una opción:");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Registrar Estudiante");
                    RegistrarEstudiante();
                    break;
                case "2":
                    Console.WriteLine("Eliminar Estudiante");
                    
                    break;
                case "3":
                    Console.WriteLine("Consultar Estudiante");
                    Consultar();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente entre las opciones establecidas.\n");
                    Menu();
                    break;
            }
        }

        static void RegistrarEstudiante()
        {
            Console.WriteLine("Ingrese el dia de la semana (1-5) correspondientemente: ");
            int varDia = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Ingrese la materia: 1. Español, 2. Matemáticas, 3. Ciencias, 4. Sociales: ");
            int varMateria = int.Parse(Console.ReadLine());

            switch (varMateria)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del estudiante de Español: ");
                    string nombreEspañol = Console.ReadLine();
                    int indiceEsp = 0;
                    Español[varDia][indiceEsp] = nombreEspañol;
                    indiceEsp++;
                    Console.WriteLine($"Estudiante {nombreEspañol} registrado en Español para el día {varDia + 1}.");
                    break;

                case 2:
                    Console.WriteLine("Ingrese el nombre del estudiante de Matemáticas: ");
                    string nombreMatematicas = Console.ReadLine();
                    int indiceMat = 0;
                    Matematicas[varDia][indiceMat] = nombreMatematicas;
                    indiceMat++;
                    Console.WriteLine($"Estudiante {nombreMatematicas} registrado en Matemáticas para el día {varDia + 1}.");
                    break;

                case 3:
                    Console.WriteLine("Ingrese el nombre del estudiante de Ciencias: ");
                    string nombreCiencias = Console.ReadLine();
                    int indiceCien = 0;
                    Ciencias[varDia][indiceCien] = nombreCiencias;
                    indiceCien++;
                    Console.WriteLine($"Estudiante {nombreCiencias} registrado en Ciencias para el día {varDia + 1}.");
                    break;

                case 4:
                    Console.WriteLine("Ingrese el nombre del estudiante de Sociales: ");
                    string nombreSociales = Console.ReadLine();
                    int indiceSoc = 0;
                    Sociales[varDia][indiceSoc] = nombreSociales;
                    indiceSoc++;
                    Console.WriteLine($"Estudiante {nombreSociales} registrado en Sociales para el día {varDia + 1}.");
                    break;

            }

        }

        static void Consultar()
        {             Console.WriteLine("Ingrese el dia de la semana (1-5) correspondientemente: ");
            int varDia = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Ingrese la materia: 1. Español, 2. Matemáticas, 3. Ciencias, 4. Sociales: ");
            int varMateria = int.Parse(Console.ReadLine());
            switch (varMateria)
            {
                case 1:
                    Console.WriteLine($"Estudiantes registrados en Español para el día {varDia + 1}:");
                    foreach (var estudiante in Español[varDia])
                    {
                        if (estudiante != null)
                        {
                            Console.WriteLine(estudiante);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine($"Estudiantes registrados en Matemáticas para el día {varDia + 1}:");
                    foreach (var estudiante in Matematicas[varDia])
                    {
                        if (estudiante != null)
                        {
                            Console.WriteLine(estudiante);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine($"Estudiantes registrados en Ciencias para el día {varDia + 1}:");
                    foreach (var estudiante in Ciencias[varDia])
                    {
                        if (estudiante != null)
                        {
                            Console.WriteLine(estudiante);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine($"Estudiantes registrados en Sociales para el día {varDia + 1}:");
                    foreach (var estudiante in Sociales[varDia])
                    {
                        if (estudiante != null)
                        {
                            Console.WriteLine(estudiante);
                        }
                    }
                    break;
            }
        }



        static void Main(string[] args)
        {
            IniciarEspañol();
            IniciarMatematica();
            IniciarCiencias();
            IniciarSociales();
            while (true)
            {
                Menu();
                Console.WriteLine("\n¿Desea realizar otra operación? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta != "s")
                {
                    Console.WriteLine("Ha salido del menu");
                    break;
                }
            }


        }
    }
}

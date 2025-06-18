using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    internal class Program
    {
        // He desarrollado este programa en base a un modelo de estructura de datos que funciona por medio
        // de "arreglos de arreglos". Decidi dessarrollarlo de esta manera ya que la trabaje anteriormente en
        // un proyecto de python, con este tipo de estructura pienso que es mas facil acceder a los datos y
        // manupularlos, tambien en mi opinion es mas facil de leer y entender su funcionamiento. Aunuque 
        // desconozco si es viable en terminos de optimizacion.

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
                Matematicas[dia] = new string[3];
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
                    EliminarEstudiante();
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
            Console.WriteLine("\n");
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
                    
                    for (int i = 0; i < Español[varDia].Length; i++)
                    {
                        if (Español[varDia][i] == null)
                        {
                            Español[varDia][i] = nombreEspañol;
                            Console.WriteLine($"Estudiante {nombreEspañol} registrado en Español para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    Console.WriteLine("No hay espacio disponible para más estudiantes en este día y materia.\n");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre del estudiante de Matemáticas: ");
                    string nombreMatematicas = Console.ReadLine();
                    for (int i = 0; i < Matematicas[varDia].Length; i++)
                    {
                        if (Matematicas[varDia][i] == null)
                        {
                            Matematicas[varDia][i] = nombreMatematicas;
                            Console.WriteLine($"Estudiante {nombreMatematicas} registrado en Matemáticas para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    Console.WriteLine("No hay espacio disponible para más estudiantes en este día y materia.\n");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del estudiante de Ciencias: ");
                    string nombreCiencias = Console.ReadLine();
                    for (int i = 0; i < Ciencias[varDia].Length; i++)
                    {
                        if (Ciencias[varDia][i] == null)
                        {
                            Ciencias[varDia][i] = nombreCiencias;
                            Console.WriteLine($"Estudiante {nombreCiencias} registrado en Ciencias para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    Console.WriteLine("No hay espacio disponible para más estudiantes en este día y materia.\n");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre del estudiante de Sociales: ");
                    string nombreSociales = Console.ReadLine();
                    for (int i = 0; i < Sociales[varDia].Length; i++)
                    {
                        if (Sociales[varDia][i] == null)
                        {
                            Sociales[varDia][i] = nombreSociales;
                            Console.WriteLine($"Estudiante {nombreSociales} registrado en Sociales para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    Console.WriteLine("No hay espacio disponible para más estudiantes en este día y materia.\n");
                    break;
            }

        }

        static void EliminarEstudiante()
        {
            Console.WriteLine("Ingrese el dia de la semana (1-5) correspondientemente: ");
            int varDia = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Ingrese la materia: 1. Español, 2. Matemáticas, 3. Ciencias, 4. Sociales: ");
            int varMateria = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del estudiante a eliminar: ");
            string nombreEstudiante = Console.ReadLine();
            switch (varMateria)
            {
                case 1:
                    for (int i = 0; i < Español[varDia].Length; i++)
                    {
                        if (Español[varDia][i] == nombreEstudiante)
                        {
                            Español[varDia][i] = null;
                            Console.WriteLine($"Estudiante {nombreEstudiante} eliminado de Español para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < Matematicas[varDia].Length; i++)
                    {
                        if (Matematicas[varDia][i] == nombreEstudiante)
                        {
                            Matematicas[varDia][i] = null;
                            Console.WriteLine($"Estudiante {nombreEstudiante} eliminado de Matemáticas para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < Ciencias[varDia].Length; i++)
                    {
                        if (Ciencias[varDia][i] == nombreEstudiante)
                        {
                            Ciencias[varDia][i] = null;
                            Console.WriteLine($"Estudiante {nombreEstudiante} eliminado de Ciencias para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < Sociales[varDia].Length; i++)
                    {
                        if (Sociales[varDia][i] == nombreEstudiante)
                        {
                            Sociales[varDia][i] = null;
                            Console.WriteLine($"Estudiante {nombreEstudiante} eliminado de Sociales para el día {varDia + 1}.\n");
                            return;
                        }
                    }
                    break;


            }
            Console.WriteLine($"{nombreEstudiante} no se ha encontrado en la materia seleccionada del día {varDia + 1}.\n");
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
                Console.WriteLine("¿Desea realizar otra operación? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
                if (respuesta != "s")
                {
                    Console.WriteLine("Ha salido del menu");
                    break;
                }
            }


        }
    }
}

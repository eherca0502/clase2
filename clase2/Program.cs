using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clase2
{
    internal class Estudiante
    {
        public static string Nombre { get; set; }
        public static int Edad { get; set; }
        public static string Matricula { get; set; }
        public static string Carrera { get; set; }
        public static string Universidad { get; set; }

        public static void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Carrera: " + Carrera);
            Console.WriteLine("Universidad: " + Universidad);
        }
        public static void Estudiar()
        {
            Console.WriteLine(Nombre + "esta estudiando sistemas");

        }
        public static void AsistirClases()
        {
            Console.WriteLine(Nombre + "esta asistiendo a clases de ingles");
        }
        public static void HacerExamen()
        {
            Console.WriteLine(Nombre + "esta haciendo un examen de calculo integral");
        }
        public static void ParticiparProyecto()
        {
            Console.WriteLine(Nombre + "esta realizando un proyecto de redes");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre?");
            Nombre = Console.ReadLine();
            Console.WriteLine("Cual es tu edad?");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Cual es tu matricula?");
            Matricula = Console.ReadLine();
            Console.WriteLine("Cual es tu carrera?");
            Carrera = Console.ReadLine();
            Console.WriteLine("Cual es tu universidad?");
            Universidad = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("SELECCIONA LA OPERACION QUE DESEAS REALIZAR");
                Console.WriteLine("1 Mostrar toda la informacion");
                Console.WriteLine("2 Esta estudiando  ?");
                Console.WriteLine("3 Asiste a clases?");
                Console.WriteLine("4 Esta realizando un examen ?");
                Console.WriteLine("5 Esta realizando un proyecto de ?");
                Console.WriteLine();

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarInformacion();
                        break;
                    case 2:
                        Estudiar();
                        break;
                    case 3:
                        AsistirClases();
                        break;
                        case 4:
                        HacerExamen();
                        break;
                        case 5:
                        ParticiparProyecto();
                        break;

                }
                Console.ReadKey();
            } while (true);
        }
    }
}
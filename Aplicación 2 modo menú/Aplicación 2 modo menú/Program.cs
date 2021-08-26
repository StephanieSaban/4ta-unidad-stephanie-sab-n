using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicación_2_modo_menú
{
    class Program
    {
        static void Main(string[] args)
        {
            char tiempo;
            int op = 0;
            

            Console.Write("¿Desea hacer la escritura de datos en un archivo seleccionado ?: s/n ");
            tiempo = char.Parse(Console.ReadLine());
            while (tiempo == 's')
            {
                Console.WriteLine("Menu de escritura de un archivo:");
                Console.WriteLine("1. Creación del archivo:");
                Console.WriteLine("2. Editar archivo:");
                Console.WriteLine("3. Mostrar archivo: ");
                Console.WriteLine("4. Salir: ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("anota el nombre del archivo: ");
                    string archivo = Console.ReadLine();

                    StreamWriter nombre;
                    nombre = File.CreateText(archivo + ".txt");
                    nombre.WriteLine("SE HA CREADO EL ARCHIVO DESEADO...");
                    nombre.Close();

                }

                if (op == 2)
                {
                    StreamWriter wr;
                    Console.WriteLine("Nombre del archivo: ");
                    string archivo = Console.ReadLine();
                    Console.WriteLine("escribe: ");
                    string editar = Console.ReadLine();
                    wr = File.AppendText(archivo + ".txt");
                    wr.WriteLine(editar);
                    wr.Close();
                    Console.Clear();
                }                

                if (op == 3)
                {
                    StreamReader rL;
                    string leer;
                    string contenido;
                    Console.WriteLine("Archivo a leer:");
                    leer = Console.ReadLine();
                    Console.WriteLine(" ");
                    rL = File.OpenText(leer + ".txt");
                    contenido = rL.ReadToEnd();
                    Console.WriteLine(contenido);
                    rL.Close();
                    Console.ReadKey();
      
                }


                else if (op == 4)
                {
                    Environment.Exit(0);
                }

            }
        }
    }
}

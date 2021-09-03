using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicación_3
{
    class Program
    {
        static void Main(string[] args)
        {

            char tiempo;
            int op = 0;
            string nombree = "";
            string apellido = "";
            string telefono = "";
            string dirección = "";
            string linea = "";
            StreamReader Rar;
            string archivo = "";
            string buscar = "";
            string borrar = "";



            Console.Write("¿Desea crear una Agenda?: s/n ");
            tiempo = char.Parse(Console.ReadLine());
            while (tiempo == 's')
            {
                Console.WriteLine("Menu de agenda:");
                Console.WriteLine("1. Creación de la agenda:");
                Console.WriteLine("2. Ingreso de datos:");
                Console.WriteLine("3. Busqueda de contactos: ");
                Console.WriteLine("4. Borrar contacto: ");
                Console.WriteLine("5. Salir: ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("anota el nombre de la agenda: ");
                    archivo = Console.ReadLine();

                    StreamWriter nombre;
                    nombre = File.CreateText(archivo + ".txt");
                    nombre.WriteLine("Contacto creado...");
                    nombre.Close();

                }

                if (op == 2)
                {
                    StreamWriter wr;
                    System.Console.Write("ingrese nombre:");
                    nombree = System.Console.ReadLine();
                    System.Console.Write("ingrese apellido:");
                    apellido = System.Console.ReadLine();
                    System.Console.Write("ingrese telefono:");
                    telefono = System.Console.ReadLine();
                    System.Console.Write("ingrese dirección:");
                    dirección = System.Console.ReadLine();
                    string editar = nombree + "*" + apellido + "*" + telefono + "*" + dirección;
                    wr = File.AppendText(archivo + ".txt");
                    wr.WriteLine(editar);
                    wr.Close();
                    Console.Clear();
                }

                if (op == 3)
                {
                    Buscar();
                    Console.Clear();
                }
                else if (op == 4)
                {
                    Borrar();
                    Console.Clear();
                }
                else if (op == 5)
                {
                    Environment.Exit(0);
                }


            }


        }

        static void Buscar()
        {
            
            string[] vec = new string[4];
            char delimitador = '*';
            string linea, dato;
            StreamReader leer;
            leer = File.OpenText("agenda.txt");
            Console.WriteLine("Ingresa el dato a buscar:");
            dato = Console.ReadLine();
            linea = leer.ReadLine();
            bool encontrado = false;
            while (linea != null && encontrado == false)
            {
                vec = linea.Split(delimitador);
                if (vec[0] == dato)
                {
                    Console.WriteLine("Nombre: " + vec[0]);
                    Console.WriteLine("Apellido: " + vec[1]);
                    Console.WriteLine("Telefono: " + vec[2]);
                    Console.WriteLine("Direción: " + vec[3]);
                    encontrado = true;
                    System.Console.WriteLine("contacto encontrado" + encontrado);


                }
                else
                {
                    linea = leer.ReadLine();
                    
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("No encontrado.");
            }
             leer.Close();
        }


        static void Borrar()
        {
            string[] contactos = new string[3];
            char delimitador = '*';
            string linea, eliminar;
            StreamWriter traslado;
            StreamReader leer;
            leer = File.OpenText("agenda.txt");
            traslado = File.CreateText("agendaborrar.txt");
            System.Console.Write("Ingrese contacto a borrar: ");
            eliminar = System.Console.ReadLine();
            linea = leer.ReadLine();
            bool dato = false;
            while (linea != null)
            {
                string[] contacto = linea.Split(delimitador);
                if (contacto[0] == eliminar)
                {
                    dato = true;
                }
                else
                {
                    traslado.WriteLine(linea);
                }
                linea = leer.ReadLine();
            }
            if (dato == false)
            {
                Console.WriteLine("Contacto no encontrado.");
            }
            else
            {
                Console.WriteLine("Contacto Eliminado");
            }
            traslado.Close();
            leer.Close();
            File.Delete("agenda.txt");
            File.Move("agendaborrar.txt", "agenda.txt");


        }
    }
}


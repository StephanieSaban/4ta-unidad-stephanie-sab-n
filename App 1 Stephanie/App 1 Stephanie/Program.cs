using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_1_Stephanie
{
    class Program
    {
        static void Main(string[] args)
        {
            char tiempo;
            Console.Write("¿desea crear un archivo ?: s/n ");
            tiempo = char.Parse(Console.ReadLine());
            if (tiempo == 's')
            {
                Console.WriteLine("anota el nombre del archivo: ");
                string archivo = Console.ReadLine();

                StreamWriter nombre;
                nombre = File.CreateText(archivo + ".txt");
                nombre.WriteLine("HOLA AQUI SE CREO EL ARCHIVO CON EL NOMBRE QUE ELIGIÓ, BIENVENIDO SEAS");
                nombre.Close();

                Console.Write("¿desea crear otro archivo ?: s/n ");
                tiempo = char.Parse(Console.ReadLine());
                Console.Clear();

            }
            if (tiempo == 's')
            {
                Console.WriteLine("anota el nombre del archivo: ");
                string archivo = Console.ReadLine();

                StreamWriter nombre;
                nombre = File.CreateText(archivo + ".txt");
                nombre.WriteLine("HOLA AQUI SE CREO EL ARCHIVO CON EL NOMBRE QUE ELIGIÓ, BIENVENIDO SEAS");
                nombre.Close();



            }
        }
    }   
}

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
            string R = "s";
            while (R == "s")
            {
                Console.WriteLine("Escribe el nombre del archivo: ");
                string archivo = Console.ReadLine();


                StreamWriter nombre;
                nombre = File.CreateText(archivo + ".txt");
                nombre.WriteLine("HOLA AQUI SE CREO EL ARCHIVO CON EL NOMBRE QUE ELIGIÓ...");
                nombre.Close();


                Console.WriteLine("Quieres crear otro archivo?");
                Console.WriteLine("s/n");
                R = Console.ReadLine();
                Console.Clear();
                if (R == "no")
                {
                    return;
                }
            }
    }    }
}

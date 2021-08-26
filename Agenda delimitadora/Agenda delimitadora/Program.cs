using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda_delimitadora
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter War;
            StreamReader Rar;
            string linea1 = "";
            string nombre = "";
            string apellido = "";
            string telefono = "";
            string dirección = "";
            string buscar = "";
            string agenda = "Agenda.txt";

            War = File.AppendText(agenda);

            for (int i = 0; i < 2; i++)
            {

                System.Console.Write("ingrese nombre:");
                nombre = System.Console.ReadLine();
                System.Console.Write("ingrese apellido:");
                apellido = System.Console.ReadLine();
                System.Console.Write("ingrese telefono:");
                telefono = System.Console.ReadLine();
                System.Console.Write("ingrese dirección:");
                dirección = System.Console.ReadLine();

             static void Escribir Archivo(string ruta, string dato)
             {
                    string linea1 = "";
                    StreamReader ar;
                    ar = File.OpenText(ruta);

                    linea1 = ar.ReadLine();
             }


                static void buscar(string ruta, string buscar)
                {
                    string linea1 = "";
                    StreamReader ar;
                    ar = File.OpenText(ruta);

                    linea1 = ar.ReadLine();
               





                    War.WriteLine(nombre + "*" + apellido + "*" + telefono + "*" + dirección);
                
                War.Close();
                System.Console.Write("Ingrese nombre a buscar: ");
                buscar = System.Console.ReadLine();

                Rar = File.OpenText(agenda);
                linea1 = Rar.ReadLine();
                while (linea1 != null)
                {
                    string[] vec = linea1.Split('*');

                    if (vec[0] == buscar)
                    {
                        System.Console.WriteLine("contacto encontrado: " + vec[0] + "--" + vec[1] + vec[2] + "-" + vec[3] + "-" + vec[4]);
                    }
                    linea1 = Rar.ReadLine();
                }
                Rar.Close();
            }

        }
    }
}

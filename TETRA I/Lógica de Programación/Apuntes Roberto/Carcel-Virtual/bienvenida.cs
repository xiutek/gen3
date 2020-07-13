using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Reflection;



namespace Carcel_Virtual
{
    class bienvenida


    {
        public static string SNombre;

        public string Nombre;



        public static int Intro1(int intro1)
        {

            Console.WriteLine(" C A R G A N D O");
            Task.Factory.StartNew(new Action(() =>
            {
                Thread.Sleep(3000);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\r\nYo sueño que estoy aquí destas prisiones cargado, y soñé que en otro estado más lisonjero me vi.");
                Console.ResetColor();
            }));

            Task.Factory.StartNew(new Action(() =>
            {
                Thread.Sleep(6000);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\r\n¿Cuál es mi nombre? (Responde con tu nombre)");
                Console.ResetColor();
                Console.WriteLine();
            }));



            return intro1;
        }

        public void Intro2()
        {


            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string texto = System.IO.File.ReadAllText(@"bienvenido.txt");
            Console.WriteLine(texto);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n\r\n ¡Escapa de la prisión antes de que se termine el tiempo! Cuidado con las 3 trampas");
            Console.ResetColor();
            SNombre = Nombre;
        }

    }
}
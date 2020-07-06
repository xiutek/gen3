using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace xp4
{
    class welcome

    {
        public string Nombre;
        public string frame = "\r\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^\r\n";
        public void Bv()
        {


            Console.WriteLine(frame);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(">> ¡Bienvenido a la isla del tesoro, " + Nombre+ " <<");
            Console.ResetColor();
            Console.WriteLine(frame);

        }

    }
}

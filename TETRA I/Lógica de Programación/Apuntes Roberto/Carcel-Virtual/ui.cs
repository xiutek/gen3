using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Carcel_Virtual
{
    class ui
    {

        public static int MapX;
        public static int MapY;
        public static int ATrampaX;
        public static int ATrampaY;
        public static int BTrampaX;
        public static int BTrampaY;
        public static int CTrampaX;
        public static int CTrampaY;
        public static int UserX;
        public static int UserY;
        public static Random random = new Random();
        public static object syncLock = new object();

        public static int rnd(int min, int max)
        {
            lock (syncLock)
            {
                return random.Next(min, max);
            }
        }

        public static int Map(int cmap)
        {
            
              
            MapX = 30;
            MapY = 30;
            ATrampaX = rnd(1, 28);
            ATrampaY = rnd(1, 28);
            BTrampaX = rnd(1, 28);
            BTrampaY = rnd(1, 28);
            CTrampaX = rnd(1, 28);
            CTrampaY = rnd(1, 28);

            UserX = 15;
            UserY = 15;

            return cmap;

        }

        public static int Start(int start)
        {


            Rmap.RenderMap(1);
            // Información
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\nLos ojos de los fusiles devoran mi senda... apenas si reconocía la llanura, la muralla, el cementerio...");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n\r\n¡Esta es mi prisión! Escapa por el campo con trampas utilizando las teclas WASD");
            Console.ResetColor();
            Console.WriteLine();


            return start;

        }

    }
}
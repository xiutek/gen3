using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace xp4
{
    class ui
    {
        public static int MapX;
        public static int MapY;
        public static int ItemX;
        public static int ItemY;
        public static int UserX;
        public static int UserY;
        public static Random random = new Random();
        public static object syncLock = new object();
        public static int rnd(int min, int max)
        { 
            lock(syncLock)
            {
                return random.Next(min, max);
            }
        }

        public static int Map(int udif)
        {

            udif = Convert.ToInt32(Console.ReadLine());
            int umapx = 0;
            int umapy = 0;


            if (udif == 1)
            {
                MapX = rnd(1, 10);
                MapY = rnd(1, 10);
                umapx = MapX;
                umapy = MapY;

            }

            if (udif == 2)
            {
                MapX = rnd(5, 20);
                MapY = rnd(5, 20);
                umapx = MapX;
                umapy = MapY;
            }

            if (udif == 3)
            {
                MapX = rnd(10, 100);
                MapY = rnd(10, 200);
                umapx = MapX;
                umapy = MapY;
            }

            do
            {
                Console.WriteLine("¡No es un número válido! Intenta otra vez...");
                udif = Convert.ToInt32(Console.ReadLine());
            }
            while (udif <= 0 | udif >= 4);

            MapX = umapx;
            MapY = umapy;

            //Console.WriteLine("mapa: " + MapX + " & " + MapY);

            return udif;

        }

        public static int Render(int render)
        {


            int itemx = rnd(1, MapX);
            int itemy = rnd(1, MapY);
            ItemX = itemx;
            ItemY = itemy;

            int usrx = rnd(1, MapX);
            int usry = rnd(1, MapY);
            UserX = usrx;
            UserY = usry;
 

            //Console.WriteLine("item: " + ItemX + " & " + ItemY);
            //Console.WriteLine("usuario: " + UserX + " & " + UserY);

            return render;
        }


        public static int Start(int start)
        {


            string frame = "\r\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^\r\n";
            Console.WriteLine(frame);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(">> ¡Se ha activado el scanner geológico! << ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\nLa isla mide " + MapX + "(x) por " + MapY + "(y) unidades geológicas. \r\nTus coordenadas x: " + UserX + " || Tus coordenadas y: " + UserY);
            Console.ResetColor();
            Console.WriteLine("\r\n\r\n¡Suerte en tu búsqueda, lo vas a lograr! \r\nA menor distorsión de la señal, ¡más cerca te encuentras del tesoro!"+ "\r\n"+frame+ "\r\n");
            
            Console.ResetColor();
            Console.WriteLine();

            return start;
        
        }

    }
}

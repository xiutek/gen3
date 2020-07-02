using System;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace xp4
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();


            string frame1 = "\r\n^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V\r\n";
            string frame2 = "\r\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^\r\n";
            string xiu = "       .__        __          __    \r\n" +
                "___  __|__|__ ___/  |_  ____ |  | __\r\n" +
                "\\  \\/  /  |  |  \\   __\\/ __ \\|  |/ /\r\n" +
                " >    <|  |  |  /|  | \\  ___/|    < \r\n" +
                "/__/\\_ \\__|____/ |__|  \\___  >__|_ \\ \r\n" +
                "      \\/                   \\/     \\/\r\n";


            Console.WriteLine(frame1 + "¡Bienvenido a la búsqueda del tesoro!" + frame2);
            Console.WriteLine("Selecciona la dificultad: 1, 2, 3");
            int dif = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int mapx = 5;
            int mapy = 5;

            do
            {
                Console.WriteLine("¡Esta no es una opción válida!");
                Console.WriteLine("Selecciona la dificultad: 1, 2, 3");
                dif = (Convert.ToInt32(Console.ReadLine()));
            }
            while (dif <= 0 | dif >= 4);

            if (dif == 1)
            {
                mapx = rnd.Next(3, 5);
                mapy = rnd.Next(3, 5);
            }
            if (dif == 2)
            {
                mapx = rnd.Next(5, 10);
                mapy = rnd.Next(5, 10);
            }
            if (dif == 3)
            {
                mapx = rnd.Next(10, 100);
                mapy = rnd.Next(10, 100);
            }

            int itemx = rnd.Next(1, mapx);
            int itemy = rnd.Next(1, mapy);
            int usrx = rnd.Next(1, mapx);
            int usry = rnd.Next(1, mapy);

            Console.WriteLine(frame1 + "¡Intenta encontrar el tesoro! \r\n(Tamaño del mapa: " + mapx + " x " + mapy + ")\r\n");

            //Console.WriteLine("Esto es una trampa! El item está en: " + itemx + " , " + itemy);
            Console.WriteLine(">> Tu posición x: " + usrx + " || Tu posición y: " + usry + "<<" + frame2);
            Console.WriteLine("Elige cúantas casillas trasladarte en X");
            int movx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elige cúantas casillas trasladarte en y");
            int movy = Convert.ToInt32(Console.ReadLine());
            int locx = usrx + movx;
            int locy = usry + movy;
            float uhint;
            int intentos = 1;

            do
            {
                Console.WriteLine("\r\n" + frame1 + "¡Vuelve a intentarlo! \r\n>> Posición actual: (" + locx + ", " + locy + ") <<");
                float hintx = itemx - locx;
                float hinty = itemy - locy;
                float ux = (Math.Abs(hintx) / 2);
                float uy = (Math.Abs(hinty) / 2);
                uhint = ux + uy;
                Console.WriteLine("Distorsión de la señal: " + uhint + frame2);
                Console.WriteLine("Elige cúantas casillas trasladarte en X");
                locx = locx + (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Elige cúantas casillas trasladarte en y");
                locy = locy + (Convert.ToInt32(Console.ReadLine()));
                intentos = intentos + 1;

            }
            while ((locx != itemx | locy != itemy));

            Console.WriteLine(frame1 + "¡Felicidades, haz encontrado el Tesoro!\r\n");
            Console.WriteLine("Número de intentos: " + intentos);
            Console.WriteLine("\r\n\r\n" + xiu);




        }
    }
}
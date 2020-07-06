using System;
using System.Collections.Generic;
using System.Text;

namespace xp4
{
    public class blueprint
    {
        public static void Main(string[] args)
        {

            // FUNCIONES
            Random rnd = new Random();

            
            // HEADERS Y FOOTER
            string frame1 = "\r\n^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V^V\r\n";
            string frame2 = "\r\n~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^\r\n";
            string xiu = "       .__        __          __    \r\n" +
                "___  __|__|__ ___/  |_  ____ |  | __\r\n" +
                "\\  \\/  /  |  |  \\   __\\/ __ \\|  |/ /\r\n" +
                " >    <|  |  |  /|  | \\  ___/|    < \r\n" +
                "/__/\\_ \\__|____/ |__|  \\___  >__|_ \\ \r\n" +
                "      \\/                   \\/     \\/\r\n";


            // WELCOME
            Console.WriteLine(frame1 + "\r\n¡Bienvenido a la búsqueda del tesoro!\r\n" + frame2);
            
            
            // SELECCION DE LA DificultadICULTAD
            int Dificultad;

            // ESTE ES EL MAPA
            int MapaX = 5;
            int MapaY = 5;

            // ESTE DO CAMBIA EL TAMAÑO DEL MAPA
            do
            {
                Console.WriteLine("Selecciona la Dificultadicultad: 1, 2, 3");
                Dificultad = (Convert.ToInt32(Console.ReadLine()));
            }
            while (Dificultad <= 0 | Dificultad >= 4);

            if (Dificultad == 1)
            {
                MapaX = rnd.Next(3, 5);
                MapaY = rnd.Next(3, 5);
            }
            if (Dificultad == 2)
            {
                MapaX = rnd.Next(5, 10);
                MapaY = rnd.Next(5, 10);
            }
            if (Dificultad == 3)
            {
                MapaX = rnd.Next(10, 100);
                MapaY = rnd.Next(10, 100);
            }

            // AQUI SE LE ASIGNA VALOR RANDOM DENTRO DEL MAPA AL TESORO
            int itemx = rnd.Next(1, MapaX);
            int itemy = rnd.Next(1, MapaY);

            // AQUÍ SE LE ASIGNA VALLOR RANDOM DENTRO DEL MAPA A PLAYER
            int usrx = rnd.Next(1, MapaX);
            int usry = rnd.Next(1, MapaY);

            
            
            // COMIENZA EL JUEGO!
            Console.WriteLine(frame1 + "¡Intenta encontrar el tesoro! \r\n(Tamaño del mapa: " + MapaX + " x " + MapaY + ")\r\n");



            // INFORMACION INICIAL AL USUARIO
            //Console.WriteLine("Esto es una trampa! El item está en: " + itemx + " , " + itemy);
            Console.WriteLine(">> Tu posición x: " + usrx + " || Tu posición y: " + usry + " <<\r\n" + frame2);
            
            // PRIMER INTENTO DEL USUARIO, INICIA EL CONTADOR DE INTENTOS Y "DISTORSION DE LA SEÑAL"
            Console.WriteLine("Elige cúantas casillas trasladarte en X");
            int movx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elige cúantas casillas trasladarte en y");
            int movy = Convert.ToInt32(Console.ReadLine());
            int locx = usrx + movx;
            int locy = usry + movy;
            float uhint;
            int intentos = 1;


            // INTENTOS SUBSECUENTES
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
            // CONDICION DE VICTORIA
            while ((locx != itemx | locy != itemy));


            // FIN DEL JUEGO
            Console.WriteLine(frame1 + "¡Felicidades, haz encontrado el Tesoro!\r\n");
            Console.WriteLine("Número de intentos: " + intentos);
            Console.WriteLine("\r\n\r\n" + xiu);

        }
    }
}

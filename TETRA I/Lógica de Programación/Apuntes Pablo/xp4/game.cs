using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace xp4
{
    public class game
    {
        public static int MoveX;
        public static int MoveY;
        public static int LocX;
        public static int LocY;
        public static float HintX;
        public static float HintY;
        public static float Hint;
        public static int Intentos;



        public static int FPlay(int fplay)
        {

            string frame = "~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^";

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(">> Elige cúantas casillas trasladarte en x (Números enteros positivos y negativos)");
            Console.ResetColor();
            int movx = Convert.ToInt32(Console.ReadLine());


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(">> Elige cúantas casillas trasladarte en y (Números enteros positivos y negativos)");
            Console.ResetColor();
            int movy = Convert.ToInt32(Console.ReadLine());


            LocX = movx + ui.UserX;
            LocY = movy + ui.UserY;
            HintX = ui.ItemX - LocX;
            HintY = ui.ItemY - LocY;
            Hint = ((Math.Abs(HintX)) + (Math.Abs(HintY))) / 2;

            Console.WriteLine(frame);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\nTus coordenadas actuales: " + LocX + " & " + LocY);
            Console.WriteLine("Distorsión de la señal: " + Hint);
            Console.ResetColor();
            Intentos = 1;
            Console.WriteLine("Intentos: " + Intentos);
            Console.WriteLine(frame);

            return fplay;
        }

        public static int LPlay(int lplay)
        {
            do
            {
                string frame = "~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^~^";


                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(">> Elige cúantas unidades trasladarte en x");
                Console.ResetColor();
                int movx = Convert.ToInt32(Console.ReadLine());

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(">> Elige cúantas unidades trasladarte en y");
                Console.ResetColor();
                int movy = Convert.ToInt32(Console.ReadLine());


                LocX = movx + LocX;
                LocY = movy + LocY;
                HintX = ui.ItemX - LocX;
                HintY = ui.ItemY - LocY;
                Hint = ((Math.Abs(HintX)) + (Math.Abs(HintY))) / 2;

                Console.WriteLine(frame);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\r\nTus coordenadas actuales: " + LocX + " & " + LocY);
                Console.WriteLine("Distorsión de la señal: " + Hint);
                Console.ResetColor();
                Intentos = Intentos + 1;
                Console.WriteLine("Intentos: " + Intentos);
                Console.WriteLine(frame);


            }
            while ((LocX != ui.ItemX | LocY != ui.ItemY));

            return lplay;
        }

        public static int Fin(int fin)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n\r\n¡Felicidades, haz encontrado el tesoro!");
            Console.WriteLine("Número de intentos: " + Intentos);
            Console.ResetColor();
            Console.WriteLine("\r\n\r\n");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("       .__        __          __    \r\n" +
                "___  __|__|__ ___/  |_  ____ |  | __\r\n" +
                "\\  \\/  /  |  |  \\   __\\/ __ \\|  |/ /\r\n" +
                " >    <|  |  |  /|  | \\  ___/|    < \r\n" +
                "/__/\\_ \\__|____/ |__|  \\___  >__|_ \\ \r\n" +
                "      \\/                   \\/     \\/\r\n");
            return (fin);

        }
    }
}

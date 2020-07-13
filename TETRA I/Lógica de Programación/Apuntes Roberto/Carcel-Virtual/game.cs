using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Carcel_Virtual
{
    public class game
    {
        public static int MoveX;
        public static string vMoveX;
        public static int MoveY;
        public static string vMoveY;
        public static int LocX;
        public static int LocXv;
        public static int LocY;
        public static int LocYv;
        public static float HintX;
        public static float HintY;
        public static float Hint;
        public static float Intentos;
        public static float Bonus;
        public static float Score;


        // PRIMER MOVIMIENTO 
        public static int FPlay(int fplay)
        {

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nElige un movimiento (WASD)");
            Console.ResetColor();

            string movxv;
            movxv = Console.ReadLine().ToLower();

            vMoveX = movxv;

            switch (vMoveX)
            {
                case "w":
                    LocY = ui.UserY + 1;
                    Console.WriteLine("ok");
                    break;
                case "a":
                    LocX = ui.UserX - 1;
                    Console.WriteLine("ok");

                    break;
                case "s":
                    LocY = ui.UserY - 1;
                    Console.WriteLine("ok");

                    break;
                case "d":
                    LocX = ui.UserX + 1;
                    Console.WriteLine("ok");

                    break;
                default:
                    LocX = ui.UserX;
                    LocY = ui.UserX;
                    Console.WriteLine("No se realizó un movimiento válido");
                    break;
            }

            Rmap.RenderMap2(1);
            return fplay;

        }

        public static int SPlay(int splay)
        {

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nElige un movimiento (WASD)");
            Console.ResetColor();
            do
            {
                do
                {
                    string movxv;
                    movxv = Console.ReadLine().ToLower();

                    vMoveX = movxv;


                    switch (vMoveX)
                    {
                        case "w":
                            LocY = LocY + 1;
                            Console.WriteLine("ok");
                            break;
                        case "a":
                            LocX = LocX - 1;
                            Console.WriteLine("ok");

                            break;
                        case "s":
                            LocY = LocY - 1;
                            Console.WriteLine("ok");

                            break;
                        case "d":
                            LocX = LocX + 1;
                            Console.WriteLine("ok");

                            break;
                        default:
                            LocX = ui.UserX;
                            LocX = ui.UserX;
                            Console.WriteLine("No se realizó un movimiento válido, se regresó al inicio");
                            break;
                    }
                    Rmap.RenderMap2(1);
                } while ((LocX != ui.ATrampaX & LocY != ui.ATrampaY) |
            (LocX != ui.BTrampaX & LocY != ui.BTrampaY) |
            (LocX != ui.BTrampaX & LocY != ui.BTrampaY));

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Esta es mi muerte eterna ¡que grande!");
                Console.ResetColor();


            } while (LocX! > ui.MapX | LocY! > ui.MapY); ;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡He logrado escapar de la Prisión Virtual! La dicha eterna iluminará mi camino desde ahora...");
            Console.ResetColor();

            return splay;

        }

    }
}
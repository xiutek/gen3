using System;

namespace Carcel_Virtual
{
    class Carcel_Virtual
    {
        static void Main(string[] args)
        {
            bienvenida.Intro1(1);
            bienvenida player = new bienvenida();
            player.Nombre = (Console.ReadLine());
            player.Intro2();
            ui.Map(1);
            ui.Start(1);
            game.FPlay(1);
            game.SPlay(1);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Carcel_Virtual
{ 
    class Rmap
    {
        public static int RenderMap(int rendermap)
        {
            // Mapa
            mapa.MapTile defaultTile = new mapa.MapTile();
            defaultTile.colour = ConsoleColor.Green;
            defaultTile.character = '#';
            mapa.FillMap(defaultTile);
            // Usuario
            mapa.MapTile playerTile = new mapa.MapTile();
            playerTile.colour = ConsoleColor.Red;
            playerTile.character = 'O';

            Point playerLocation = new Point(ui.UserX, ui.UserY);
            mapa.map[playerLocation.Y, playerLocation.X] = playerTile;
            vmapa.DisplayMap();

            return rendermap;
        }

        public static int RenderMap2(int rendermap2)
        {
            // Mapa
            mapa.MapTile defaultTile = new mapa.MapTile();
            defaultTile.colour = ConsoleColor.Green;
            defaultTile.character = '#';
            mapa.FillMap(defaultTile);
            // Usuario
            mapa.MapTile playerTile = new mapa.MapTile();
            playerTile.colour = ConsoleColor.Red;
            playerTile.character = 'O';

            Point playerLocation = new Point(game.LocX, game.LocY);
            mapa.map[playerLocation.Y, playerLocation.X] = playerTile;
            vmapa.DisplayMap();

            return rendermap2;
        }
    }
}
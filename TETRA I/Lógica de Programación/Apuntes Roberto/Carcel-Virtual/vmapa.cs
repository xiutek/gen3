using System;
using System.Collections.Generic;
using System.Text;

namespace Carcel_Virtual
{
    class vmapa
    {

        public static void DisplayMap()
        {
            Console.WriteLine("\r\n\r\n");
            for (int x = 0; x < ui.MapX; x++)
            {
                for (int y = 0; y < ui.MapY; y++)
                {
                    Console.ForegroundColor = mapa.map[x, y].colour;
                    Console.Write(mapa.map[x, y].character);
                }
                Console.WriteLine();
            }
        }



    }
}

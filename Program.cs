using System;



namespace Snake
{
    class Game
    {
        static uint[,] map = new uint[30, 50];
        static uint headY = (uint)(map.GetLength(0) / 2),
                    headX = (uint)(map.GetLength(1) / 2);
        static void Main()
        {
            Console.CursorVisible = false;

            MapGen();
            Console.ReadKey();
        }

        static void MapGen()
        {
            int width = 100;
            int height = 25;
            string[,] mass = new string[width,height];


            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    if (h == 0 || h == (height - 1) || w == 0 || w == (width - 1) ) mass[w, h] = "#";
                    else mass[w, h] = " ";

                }
            }
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    if(w== (width - 1)) Console.WriteLine(mass[w, h]);
                    else Console.Write(mass[w, h]);
                }
            }


            
        }
    }
}

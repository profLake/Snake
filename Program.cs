using System;



namespace Snake
{
    class Game
    {
        static void MapGen()
        {
            int width = 50;
            int height = 30;
            int[,] mass = new int[width, height];
            int q = 0;

            for (int h = 0; h < width; h++)
            {
                for (int w = 0; w < height; w++)
                {
                    mass[h, w] = q;
                    if (q % 50 == 0)
                    {
                        Console.WriteLine(q);
                    }
                    else Console.Write(q + " ");
                    q++;
                }
            }

        }


        static void Main()
        {
            Console.CursorVisible = false;

            MapGen();

        }
    }
}

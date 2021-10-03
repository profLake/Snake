using System;



namespace Snake
{
    class Game
    {
        static int width = 100;
        static int height = 25;
        static char[,] map = new char[width,height];
        static uint headY = (uint)(map.GetLength(0) / 2),
                    headX = (uint)(map.GetLength(1) / 2);
        static char trend = 'a';
        static void SnakeMovement()
        {
            switch (Console.Read())
            {
                case 'w':
                    trend = trend == 's' ? 's' : 'w';
                    break;
                case 'a':
                    trend = trend == 'd' ? 'd' : 'a';
                    break;
                case 's':
                    trend = trend == 'w' ? 'w' : 'a';
                    break;
                case 'd':
                    trend = trend == 'a' ? 'a' : 'd';
                    break;
            }
        }

        static void Main()
        {
            Console.CursorVisible = false;

            MapGen();
            Eat();
            Vivod();
            //Console.ReadKey();
        }

        static void Vivod()
        {
            //вывод на экран
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    if (w == (width - 1)) Console.WriteLine(map[w, h]);
                    else Console.Write(map[w, h]);
                }
            }
        }

        static void MapGen()
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    if (h == 0 || h == (height - 1) || w == 0 || w == (width - 1) ) map[w, h] = '#';
                    else map[w, h] = ' ';

                }
            }  
        }
        
        static void Eat()
        {
            bool ck = true;
            while (ck)
            {
                Random wR = new Random();
                Random hR = new Random();
                int tempW = wR.Next(1, width);
                int tempH = hR.Next(1, height);
                if (map[tempW, tempH] == ' ')
                {
                    map[tempW, tempH] = '@';
                    ck = false;
                }
            }
        }

    }
}

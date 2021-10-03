using System;


namespace Snake
{
    class Game
    {
        public void MapGen()
        {
            int width = 50;
            int height = 30;

            for(int h = 0; h < width; h++)
            {
                for(int w = 0; w < height; w++)
                {
                    if (w ==0 ||w == 49) Console.Write("#");
                    else if (h == 29) Console.Write("#\n");
                    else if (w == 0 || h == 0) Console.Write("#");
                    else Console.Write(" ");

                }
            }

        }


        static void Main()
        {
            Console.CursorVisible = false;

            Game game = new Game();
            game.MapGen();

        }
    }
}

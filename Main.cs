using System;

partial class Snake
{
    static void Main()
    {
        Console.WriteLine("__Start");
        Console.CursorVisible = false;

<<<<<<< HEAD
        MapGen();

        CreateBody();
        Eat();
        MapGen();
        OutputMap();

        Console.WriteLine("Luck!");
        while (isAlive)
        {
            OutputInfo();
            BodyMovement();
            BodyCollisionCheck();
            MapGen();
            OutputMap();
        }

        Console.CursorVisible = true;
        Console.ReadKey();
=======
        FIllBody();
        FillField();

        FillApple();
        FillField();

        while (isAlive)
        {
            MoveBody();
            HandleCollision();
            FillField();
            PrintField();
            PrintInfo();
            System.Threading.Thread.Sleep((int)((1.0 / fps) * 1000));
        }

        Console.CursorVisible = true;
>>>>>>> fe33f20 (The old project is fairly completed, but I'm alone)
    }
}
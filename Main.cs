using System;

partial class Snake
{
    static void Main()
    {
        Console.WriteLine("__Start");
        Console.CursorVisible = false;

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
    }
}
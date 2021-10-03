using System;

partial class Snake
{
    static void Main()
    {
        Console.CursorVisible = false;

        MapGen();
        Eat();
        OutputMap();

        Console.ReadKey();
    }
}
using System;

partial class Snake
{
    static void CreateSnake()
    {
        body[0].y = (uint)(map.GetLength(0) / 2);
        body[0].x = (uint)(map.GetLength(1) / 2);
    }
}
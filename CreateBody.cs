using System;

partial class Snake
{
    static void CreateBody()
    {
        body[0].y = (uint)(map.GetLength(0) / 2);
        body[0].x = (uint)(map.GetLength(1) / 2);

        for (uint i = 1; i < bodyLength; i++)
        {
            body[i].y = body[i - 1].y;
            body[i].x = body[i - 1].x + 1;
        }
    }
}
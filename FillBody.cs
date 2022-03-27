using System;

partial class Snake
{
    static void FIllBody()
    {
        body[0].y = (int)(field.GetLength(0) / 2);
        body[0].x = (int)(field.GetLength(1) / 2);

        for (int i = 1; i < bodyLength; i++)
        {
            body[i].x = body[i - 1].x + 1;
            body[i].y = body[i - 1].y;
        }
    }
}
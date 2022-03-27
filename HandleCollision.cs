using System;

partial class Snake
{
    static void HandleCollision()
    {
        if (field[body[0].y, body[0].x] == ' ')
        {
            return;
        }
        if (field[body[0].y, body[0].x] == appleSymb) 
        {
            bodyLength++;
            FillApple();
            return;
        }

        isAlive = false;
        return;
    }
}
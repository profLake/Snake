using System;

partial class Snake
{
    static void BodyCollisionCheck()
    {
        if (map[body[0].y, body[0].x] == ' ')
        {
            return;
        }
        if (map[body[0].y, body[0].x] == appleSymb) 
        {
            bodyLength++;
            return;
        }

        isAlive = false;
        return;
    }
}
using System;

partial class Snake
{
    static void MoveBody()
    {
        if (Console.KeyAvailable)
        {
            char pressedKey = Console.ReadKey(true).KeyChar;
            switch (pressedKey)
            {
                case 'w':
                    headTrend = headTrend != 's' ? 'w' : 's';
                    break;
                case 'a':
                    headTrend = headTrend != 'd' ? 'a' : 'd';
                    break;
                case 's':
                    headTrend = headTrend != 'w' ? 's' : 'w';
                    break;
                case 'd':
                    headTrend = headTrend != 'a' ? 'd' : 'a';
                    break;
            }
        }

        for (int i = bodyLength - 1; i > 0; i--)
        {
            body[i].y = body[i - 1].y;
            body[i].x = body[i - 1].x;
        }
        switch (headTrend)
        {
            case 'w':
                body[0].y--;
                break;
            case 'a':
                body[0].x--;
                break;
            case 's':
                body[0].y++;
                break;
            case 'd':
                body[0].x++;
                break;
        }
    }
}

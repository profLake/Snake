using System;

partial class Snake
{
    static void BodyMovement()
    {
        char ch = Console.ReadKey(true).KeyChar;
        switch (ch)
        {
            case 'w':
                trend = trend != 's' ? 'w' : 's';
                break;
            case 'a':
                trend = trend != 'd' ? 'a' : 'd';
                break;
            case 's':
                trend = trend != 'w' ? 's' : 'w';
                break;
            case 'd':
                trend = trend != 'a' ? 'd' : 'a';
                break;
        }

        for (uint i = bodyLength - 1; i > 0; i--)
		{
			body[i].y = body[i - 1].y;
			body[i].x = body[i - 1].x;
		}
		switch (trend)
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

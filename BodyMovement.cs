using System;

partial class Snake
{
    static void BodyMovement()
    {
        switch (Console.Read())
        {
            case 'w':
                trend = trend == 's' ? 's' : 'w';
                break;
            case 'a':
                trend = trend == 'd' ? 'd' : 'a';
                break;
            case 's':
                trend = trend == 'w' ? 'w' : 'a';
                break;
            case 'd':
                trend = trend == 'a' ? 'a' : 'd';
                break;
        }
<<<<<<< HEAD:BodyMovement.cs

        for (uint i = 1; i < bodyLength; i++)
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
=======
        
>>>>>>> 6aaa19aec149cf574567cd79557ef202857f8549:HeadMovement.cs
    }
}

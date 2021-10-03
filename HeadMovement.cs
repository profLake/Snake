using System;

partial class Snake
{
    static void HeadMovement()
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
        
    }
}
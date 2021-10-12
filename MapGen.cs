using System;

partial class Snake{ 
static void MapGen()
    {
        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                if (h == 0 || h == (height - 1) || w == 0 || w == (width - 1)) map[h, w] = borderSymb;
                else map[h, w] = ' ';

            }
        }

        for (uint i = 0; i < bodyLength; i++)
        {
            Console.WriteLine($"body[i].y: {body[i].y}, body[i].x: {body[i].x}");
            map[body[i].y, body[i].x] = bodySymb;
        }
        map[apple.y, apple.x] = appleSymb;
    }
}
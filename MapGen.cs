using System;

partial class Snake{ 
static void MapGen()
    {
        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                if (h == 0 || h == (height - 1) || w == 0 || w == (width - 1)) map[w, h] = borderSymb;
                else map[w, h] = ' ';

            }
        }
    }
}
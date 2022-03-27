using System;

partial class Snake{ 
    static void FillField()
    {
        for (int y = 0; y < fieldHeight; y++)
        {
            for (int x = 0; x < fieldWidth; x++)
            {
                if (    y == 0 || y == (fieldHeight - 1)
                    ||  x == 0 || x == (fieldWidth - 1))
                    field[y, x] = fieldBorderSymb;
                else
                    field[y, x] = ' ';
            }
        }

        for (int i = 0; i < bodyLength; i++)
        {
            field[body[i].y, body[i].x] = bodySymb;
        }

        field[apple.y, apple.x] = appleSymb;
    }
}
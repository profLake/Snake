using System;

partial class Snake
{
    struct BodyCell
    {
        public int x, y;
        public BodyCell(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
    static int fieldWidth = 25;
    static int fieldHeight = 12;
    static char[,] field = new char[fieldHeight ,fieldWidth];
    static char fieldBorderSymb = '#';

    static char headTrend = 'a';
    static bool isAlive = true;
    static BodyCell[] body = new BodyCell[fieldHeight * fieldWidth];
    static int bodyLength = 4;
    static char bodySymb = '#';

    static BodyCell apple;
    static char appleSymb = '$';
    static int fps = 5;
}
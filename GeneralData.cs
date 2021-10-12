using System;

partial class Snake
{
    struct BodyCell
    {
        public uint y, x;
        public BodyCell(uint _y, uint _x)
        {
            y = _y;
            x = _x;
        }
    }
    static int width = 25;
    static int height = 12;
    static char[,] map = new char[height ,width];
    static char trend = 'a';
    static BodyCell[] body = new BodyCell[100];
    static uint bodyLength = 4;
    static char bodySymb = '#';
    static BodyCell apple;
    static char appleSymb = '$';
    static char borderSymb = '#';
    static bool isAlive = true;
}
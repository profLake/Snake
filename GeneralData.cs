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
    static int width = 100;
    static int height = 25;
    static char[,] map = new char[width,height];
    static char trend = 'a';
    static BodyCell[] body = new BodyCell[100];
}
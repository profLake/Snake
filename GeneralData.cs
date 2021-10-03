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
    static char[,] map = new char[30, 50];
    static char trend = 'a';
    static BodyCell[] body = new BodyCell[100];
}
using System;

partial class Snake{
static void Eat()
    {
        bool ck = true;
        while (ck)
        {
            Random wR = new Random();
            Random hR = new Random();
            uint tempW = (uint)wR.Next(1, width);
            uint tempH = (uint)hR.Next(1, height);
            if (map[tempH, tempW] == ' ')
            {
                apple.y = tempH;
                apple.x = tempW;
                ck = false;
            }
        }
    }
}
partial class Snake{
static void Eat()
    {
        bool ck = true;
        while (ck)
        {
            Random wR = new Random();
            Random hR = new Random();
            int tempW = wR.Next(1, width);
            int tempH = hR.Next(1, height);
            if (map[tempW, tempH] == ' ')
            {
                map[tempW, tempH] = '@';
                ck = false;
            }
        }
    }
}
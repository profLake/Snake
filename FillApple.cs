using System;

partial class Snake{
    static void FillApple()
    {
        bool placeFound = false;

        while (placeFound == false)
        {
            Random widthRGen = new Random();
            Random heightRGen = new Random();
            int tempW = (int)widthRGen.Next(1, fieldWidth);
            int tempH = (int)heightRGen.Next(1, fieldHeight);
            if (field[tempH, tempW] == ' ')
            {
                apple.y = tempH;
                apple.x = tempW;
                placeFound = true;
            }
        }
    }
}
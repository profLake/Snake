using System;

public partial class Snake
{ 
   static void PrintField()
    {
        //вывод на экран
        for (int h = 0; h < fieldHeight; h++)
        {
            for (int w = 0; w < fieldWidth; w++)
            {
                Console.Write(field[h, w]);
            }
            Console.WriteLine();
        }
    }
}
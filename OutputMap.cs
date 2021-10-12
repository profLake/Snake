using System;

public partial class Snake
{ 
   static void OutputMap()
    {
        //вывод на экран
        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                Console.Write(map[h, w]);
            }
            Console.WriteLine();
        }
    }
}
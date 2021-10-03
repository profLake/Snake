public partial class Snake
{ 
   static void OutputMap()
    {
        //вывод на экран
        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                if (w == (width - 1)) Console.WriteLine(map[w, h]);
                else Console.Write(map[w, h]);
            }
        }
    }
}
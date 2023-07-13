int[,] arr = new int[4, 4];

Console.WriteLine("The array is created");
Console.WriteLine("Here is the upper line");

CreateLine(arr);
DrawArray(arr);

Console.WriteLine();
CreateLine2(arr);
DrawArray(arr);

void CreateLine(int[,] array)
{
    int width = array.GetLength(0);
    int height = array.GetLength(1);

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            array[j, 0] = 1;
        }
    }
}

//other way of imaginig the indexes - flipping the inner and outer cycle instead of flippin indexes
void CreateLine2(int[,] array)
{
    int width = array.GetLength(0);
    int height = array.GetLength(1);

    for (int j = 0; j < height; j++)
    {
        for(int i = 0; i < width; i++)
        {
            array[0, i] = 1;
        }
    }
}

void DrawArray(int[,] array)
{
    int width = array.GetLength(0);
    int height = array.GetLength(1);

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            Console.Write(array[j, i]);
        }
        Console.WriteLine();
    }
}
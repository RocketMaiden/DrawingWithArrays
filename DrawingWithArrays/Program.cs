int[,] arr = new int[4, 4];
int[,] arr2 = new int[4, 4];
int[,] arr3 = new int[4, 4];
int[,] arr4 = new int[4, 4];

Console.WriteLine("The array is created");
Console.WriteLine("Here is the upper line");

CreateLine(arr);
DrawArray(arr);

//Console.WriteLine();
//CreateLine2(arr2);
//DrawArray(arr);

Console.WriteLine("Here is an upper left to bottom right diagonal");
CreateDiagonalUpLeftBtmRight(arr3);
DrawArray(arr3);

Console.WriteLine("Here is an upper right to bottom left diagonal");
CreateDiagonalUpRightBtmLeft(arr4);
DrawArray(arr4);


//indexing to row as to column with 0 height
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

void CreateDiagonalUpLeftBtmRight(int[,] array)
{
    int width = array.GetLength(0);
    int height = array.GetLength(1);

    for(int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            if(j == i)
            {
                array[i, j] = 1;
            }
        }
    }
}

void CreateDiagonalUpRightBtmLeft(int[,] array)
{
    int width = array.GetLength(0);
    int height = array.GetLength(1);

    for(int i = 0; i < width; i++)
    {
        for( int j = 0; j < height; j++)
        {
            if (j == height - i - 1)
            {
                array[i, j] = 1;
            }
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
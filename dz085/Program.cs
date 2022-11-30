// 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int m = 4,
    n = 4,
    xMin = 0,
    yMin = 0,
    xMax = m - 1,
    yMax = n - 1,
    value = 1,
    x = xMin,
    y = yMin;

int[,] array = new int[m, n];


while (value <= m * n)
{
    while (y <= yMax)
    {
        array[x, y] = value;
        y++;
        value++;
    }
    xMin++;
    y--;
    x++;
    while (x < xMax)
    {
        array[x, y] = value;
        x++;
        value++;
    }
    yMax--;
    while (y > yMin)
    {
        array[x, y] = value;
        y--;
        value++;
    }
    xMax--;
    while (x > xMin)
    {
        array[x, y] = value;
        x--;
        value++;
    }
    yMin++;
}

PrintArray(array);



void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}


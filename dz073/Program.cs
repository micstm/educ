// 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int numString = InputNumber("строк");
int numColumn = InputNumber("столбцов");

int[,] array = GetArray(numString, numColumn);

PrintArray(array);
Console.WriteLine("-------------------------");

double[] average = CalcAverage(array);

PrintArray1(average);

//----------

int InputNumber(string num)
{
    while (true)
    {
        Console.Write($"Введите количество {num}: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}


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


double[] CalcAverage(int[,] tArray)
{
    int sum;
    double[] average = new double[tArray.GetLength(1)];
    for (int i = 0; i < tArray.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < tArray.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        average[i] = (double) sum / tArray.GetLength(0);
    }
    return average;
}


void PrintArray1(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

// 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int numString = InputNumber("строк");
int numColumn = InputNumber("столбцов");

double[,] array = GetArray(numString, numColumn);

PrintArray(array);

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


double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble()*10,1);
        }
    }
    return result;
}


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}


// 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int numString = InputNumber("строк");
int numColumn = InputNumber("столбцов");

int[,] array = GetArray(numString, numColumn);

PrintArray(array);
Console.WriteLine("-------------------------");

int[,] sortArray = SortingArray(array);
PrintArray(sortArray);

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


int[,] SortingArray(int[,] result)
{
    int max,
        index;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            max = result[i, j];
            index = j;
            for (int k = j + 1; k < result.GetLength(1); k++)
            {
                if(result[i, k] > max)
                {
                    max = result[i, k];
                    index = k;
                }
            }
            result[i, index] = result[i, j];
            result[i, j] = max;
        }
    }
    return(result);
}
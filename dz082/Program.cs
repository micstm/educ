// 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка


int numString = InputNumber("строк");
int numColumn = InputNumber("столбцов");

int[,] array = GetArray(numString, numColumn);
PrintArray(array);

int[] sumArray = SumStringElem(array);

Console.WriteLine($"Наименьшая сумма элементов в строке {SearchMinString(sumArray)}");

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


int[] SumStringElem(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumArray[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] += array[i,j];
        }
        Console.Write($"{sumArray[i]} ");
    }
    return(sumArray);
}


int SearchMinString(int[] sumArray)
{
    int min = sumArray[0],
        index = 0;
    for (int i = 1; i < sumArray.Length; i++)
    {
        if(min > sumArray[i])
        {
            min = sumArray[i];
            index = i;
        }
    }
    return(index);
}
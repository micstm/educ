// 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int numStringA = InputNumber("строк матрицы А");
int numColumnA = InputNumber("столбцов матрицы А");
int numStringB = numColumnA;
int numColumnB = InputNumber("столбцов матрицы B");

int[,] arrayA = GetArray(numStringA, numColumnA);
PrintArray(arrayA);
Console.WriteLine();
int[,] arrayB = GetArray(numStringB, numColumnB);
PrintArray(arrayB);
Console.WriteLine("Результат умножения матриц:");

int[,] resultArray = MultiplyMatrix(arrayA, arrayB);
PrintArray(resultArray);


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


int[,] MultiplyMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] resultArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                resultArray[i, j] += arrayA[i, k] * arrayB[k,j];
            }
        }
    }
    return(resultArray);
}
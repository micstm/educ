// 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[,]
{
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}
};

int numString = InputNumber("строку");
int numColumn = InputNumber("столбец");

PrintArray(array);

Console.Write($"{numString}, {numColumn} -> ");
if(numString < 3 && numColumn < 4)
    Console.WriteLine(array[numString, numColumn]);
else Console.WriteLine("такого элемента в массиве нет");

//----------

int InputNumber(string num)
{
    while (true)
    {
        Console.Write($"Введите {num}: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


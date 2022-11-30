// 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int lenghtArray = InputNumber("первое измерение", 90);
int widthArray = InputNumber("второе измерение", 90 / lenghtArray);
int depthArray = InputNumber("третье измерение", 90 / lenghtArray / widthArray);

int[,,] array = GetArray(lenghtArray, widthArray, depthArray);

PrintArray(array);

//----------

int InputNumber(string message, int num)
{
    while (true)
    {
        Console.Write($"Введите {message} (от 1 до {num}): ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int[,,] GetArray(int lenghtArray, int widthArray, int depthArray)
{
    int[,,] result = new int[lenghtArray, widthArray, depthArray];
    int temp;
    for (int i = 0; i < lenghtArray; i++)
    {
        for (int j = 0; j < widthArray; j++)
        {
            for (int k = 0; k < depthArray; k++)
            {
                while (true)
                {
                    temp = new Random().Next(10, 100);
                    if (ChekNum(result, temp))
                        break;
                }
                result[i, j, k] = temp;
            }
        }
    }
    return result;
}


bool ChekNum(int[,,] result, int num)
{
    foreach (var item in result)
    {
        if (item == num)
            return (false);
    }
    return (true);
}


void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}

// 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 4;
int[] array = GetArray(size);
Console.Write(String.Join(" ", array));

int number = Count(array);
Console.WriteLine($" -> {number}");


//------------------

int Count(int[] arr)
{
    int counter = 0;
    foreach (var pos in arr)
    {
        if(pos % 2 == 0)
            counter++;
    }
    return counter;
}


int[] GetArray(int size)
{
    int[] fillArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        fillArray[i] = new Random().Next(100, 1000);
    }
    return fillArray;
}
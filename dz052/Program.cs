//  36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = 4;
int[] array = GetArray(size);
PrintArray();

int sumElem = SumElements(array);
Console.WriteLine($"-> {sumElem}");


//---------------------

void PrintArray()
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}


int SumElements(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
        if(i % 2 != 0)
            sum += arr[i];
    return sum;
}


int[] GetArray(int size)
{
    int[] fillArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        fillArray[i] = new Random().Next(-100, 100);
    }
    return fillArray;
}
// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 5;

double[] array = GetArray(size);

double maxElem = FindMax(array);
double minElem = FindMin(array);

PrintArray();
Console.WriteLine($"  ->  {maxElem - minElem}");


//------------------

void PrintArray()
{
    foreach (Double item in array)
    {
        Console.WriteLine(item);
    }
}


double FindMax(double[] arr)
{
    double max = arr[0];
    foreach (double item in arr)
    {
        if(max < item)
            max = item;
    }
    return max;
}


double FindMin(double[] arr)
{
    double min = arr[0];
    foreach (double item in arr)
    {
        if(min > item)
            min = item;
    }
    return min;
}


double[] GetArray(int size)
{
    double[] fillArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        fillArray[i] = (new Random().NextDouble()) * 100;
    }
    return fillArray;
}


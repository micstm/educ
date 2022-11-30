// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

int size = InputNumber("колмчество чисел");
int[] array = GetArray(size);

int count = Counting(array);

PrintArray();
Console.WriteLine($" -> {count}");

//----------

int InputNumber(string sym)
{
    while (true)
    {
        Console.Write($"Введите {sym}: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int[] GetArray(int size)
{
    int[] fillArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        fillArray[i] = InputNumber(i + 1 + " число");
    }
    return fillArray;
}


void PrintArray()
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}


int Counting(int[] arr)
{
    int count = 0;
    foreach (var item in arr)
        if(item > 0) count++;
    return count;
}
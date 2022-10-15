//29
//задаёт массив из 8 элементов и выводит их на экран

int size = 8;
int[] array = FillArray(size);
PrintArray();

//----------

void PrintArray()
{
    for (int i = 0; i < size; i++)
        Console.Write(array[i] + " ");
}

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i< size; i++)
        array[i] = InputNumber(i);
    return array;
}

int InputNumber(int count)
{
    while(true)
    {
        Console.Write($"Введите {count} элемент массива: ");
        bool correct = int.TryParse(Console.ReadLine(),out int number);
        if(correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}
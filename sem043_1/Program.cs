//33 от Никита Лысков
//присутствует ли заданное число в массиве


int[] array = GetArray(4, 3, 5);
PrintArray(array);

bool res = Contains(array, 4);

if (res) // если переменная res примет значение true -> проваливаемся внутрь (Console.Write("-> Да"); значение false -> идём сразу к else
{
    Console.Write("-> Да");
}
else Console.Write("-> Нет");

///////////////////////////////////////////

bool Contains(int[] elements, int find)
{
    foreach (int el in elements)
    {
        if (el == find) return true;
    }
    return false;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

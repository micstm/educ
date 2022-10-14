//выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

int size = 8;
int[] array = GetRandomNumbers(size);

for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}


static int[] GetRandomNumbers(int Size)
{
    int[] num = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        num[i] = new Random().Next(0, 2);
    }
    return num;
}

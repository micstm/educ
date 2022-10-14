//выдаёт количество знаков в числе

int number = InputNumber();
int count = Counter(number);
Console.WriteLine($"{number} -> {count}");

//----------

int InputNumber()
{
    while(true)
    {
        Console.Write("Введите число: ");
        bool correct = int.TryParse(Console.ReadLine(),out int number);
        if(correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int Counter(int number)
{
    count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return (count);
}
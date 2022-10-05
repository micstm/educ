// является ли второе кратным первому, если нет вывести остаток


int EnterNumber()
//задаём функцию ввода целого числа без ошибок
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return number;
}

int number1 = EnterNumber();
int number2 = EnterNumber();

Console.Write($"{number1}, {number2} => ");
if (number1 % number2 == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine($"не кратно, остаток {number1 % number2}");
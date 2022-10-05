// кратно ли одновременно 7 и 23

int number;
    while (true)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            break;
        Console.WriteLine("Ошибка ввода!");
    }

if (number%7==0 && number%23==0)
    Console.WriteLine($"{number} -> да");
else
    Console.WriteLine($"{number} -> нет");
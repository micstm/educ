// 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int N = InputNumber();

Console.WriteLine(PrintNaturals(N));


//----------

int InputNumber()
{
    while (true)
    {
        Console.Write("Введите целое число: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


string PrintNaturals(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    return (number + ", " + PrintNaturals(number - 1));
}
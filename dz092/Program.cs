// 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int startNumber = InputNumber("стартовое");
int finalNumber = InputNumber("финальное");

int sum = SumNumber(startNumber, finalNumber);
Console.WriteLine($"M = {startNumber}; N = {finalNumber} -> {sum}");

//----------

int InputNumber(string num)
{
    while (true)
    {
        Console.Write($"Введите {num} целое число: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int SumNumber(int startNum, int finalNum)
{
    if (startNum == finalNum)
    {
        return startNum;
    }

    return (startNum + SumNumber(startNum + 1, finalNum));
}
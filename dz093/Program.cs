// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = InputNumber("m");
int n = InputNumber("n");

int result = AckermannFunction(m, n);
Console.WriteLine($"m = {m}; n = {n} -> A(m,n) = {result}");

 
//----------

int InputNumber(string num)
{
    while (true)
    {
        Console.Write($"Введите неотрицательное число {num}: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


int AckermannFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
    return AckermannFunction(numM, numN);
}
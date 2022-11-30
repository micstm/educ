// десятичное в двоичное

int decNum = InputNumber();

double binNum = DecToBin(decNum);
Console.WriteLine(binNum);

string binNum2 = DecToBinStr(decNum);
Console.WriteLine(binNum2);


//---------------

int InputNumber()
{
    while (true)
    {
        Console.Write("Введите десятичное число: ");
        bool correct = int.TryParse(Console.ReadLine(), out int number);
        if (correct)
            return number;
        Console.WriteLine("Ошибка ввода");
    }
}


double DecToBin(int num)
{
    double res = 0,
        count = 1;
    while (num > 0)
    {
        res += (num % 2) * count;
        num /= 2;
        count *= 10;
    }
    return res;
}


string DecToBinStr(int num)
{
    string result = string.Empty;
    while (num >0)
    {
        result = num%2 + result;
        num /= 2;
    }
    return result;
}
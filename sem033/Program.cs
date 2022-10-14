//N! (факториал)

int number = InputNumber();
int fakt = Faktor(number);
Console.WriteLine($"{number} -> {fakt}");

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

int Faktor(int number)
{
    int fakt = 1,
        count = 1;
    while (count <= number)
    {
        fakt *= count;
        count++;
    }
    return fakt;
}
// день недели по номеру

Console.Write("Введите номер дня недели: ");
string userInput = Console.ReadLine() ?? "";
int dayNumber = int.Parse(userInput);

if (dayNumber == 1)
{
    Console.Write(dayNumber + " => Понелельник");
}

else if (dayNumber == 2)
{
    Console.Write(dayNumber + " => Вторник");
}

else if (dayNumber == 3)
{
    Console.Write(dayNumber + " => Среда");
}

else if (dayNumber == 4)
{
    Console.Write(dayNumber + " => Четверг");
}

else if (dayNumber == 5)
{
    Console.Write(dayNumber + " => Пятница");
}

else if (dayNumber == 6)
{
    Console.Write(dayNumber + " => Суббота");
}

else if (dayNumber == 7)
{
    Console.Write(dayNumber + " => Воскресенье");
}

else
{
    Console.Write("В неделе всего 7 дней");
}
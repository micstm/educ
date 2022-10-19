// замена символов в тексте

string text = "Компиляторы выполняют преобразование исходных текстов "
    + "проектов в исполняемые процессором последовательности команд. "
    + "Результаты такого преобразования сохраняются в так называемых "
    + "объектных файлах.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}



Console.WriteLine(text);
Console.WriteLine();

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'р', 'Р');
Console.WriteLine(newText);
Console.WriteLine();
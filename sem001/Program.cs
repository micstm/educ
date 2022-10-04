// запрашивает число, возводит в квадрат
Console.Write("Введите целое число: ");
//string? userInput = Console.ReadLine();
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

Console.WriteLine(userNumber + " -> " + userNumber * userNumber);
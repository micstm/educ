// 33
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6,7,19,345,3] -> нет
//-3; массив [6,7,19,345,-3] -> да
// решение от Вадима
//   https://github.com/SoX2022/CSharpTasks


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static int[] RandomArray(int arrayLength, int minValue, int maxValue)
{
    int[] randomArray = new int[arrayLength];

    for (int index = 0; index < arrayLength; index++)
    {
        randomArray[index] = new Random().Next(minValue, maxValue + 1);
    }

    return randomArray;
}

static void PrintArray(int[] array)
{
    Console.Write("[");
    for (int index = 0; index < array.Length - 1; index++)
        Console.Write($"{array[index]},");
    Console.Write($"{array[array.Length - 1]}]");
}

static void FindUserNumber(int[] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
        {
            Console.WriteLine("yes");
            return;
        }
    }
    Console.WriteLine("no");
}


// Console.Clear();
int length = GetNumberFromUser("Enter array length: ", "Error");
int min = GetNumberFromUser("Enter min value for your array: ", "Error");
int max = GetNumberFromUser("Enter max value for your array: ", "Error");
int userNumber = GetNumberFromUser($"Enter the number you want to find [{min},{max}]: ", "Error");
int[] array = RandomArray(length, min, max);

Console.Write($"{userNumber}; array ");
PrintArray(array);
Console.Write(" -> ");
FindUserNumber(array, userNumber);
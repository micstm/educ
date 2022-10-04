// привет, Маша

Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine() ?? "";

if(userName.ToLower() == "маша")
{
    Console.WriteLine("УРА! Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}
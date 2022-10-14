//по координатам 2 точек находим расстояние (2D)

int ax, ay, bx, by;

ax = Coords("Введите координату х первой точки: ");
ay = Coords("Введите координату y первой точки: ");
bx = Coords("Введите координату х второй точки: ");
by = Coords("Введите координату y второй точки: ");

double distance = Distance(ax, ay, bx, by);
Console.WriteLine(distance);


static int Coords(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distance(int ax, int ay, int bx, int by)
{
    double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by -ay, 2));
    return result;
}
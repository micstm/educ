//по координатам 2 точек находим расстояние (3D)

int ax, ay, az, bx, by, bz;

ax = Coords("Введите координату х первой точки: ");
ay = Coords("Введите координату y первой точки: ");
az = Coords("Введите координату z первой точки: ");
bx = Coords("Введите координату х второй точки: ");
by = Coords("Введите координату y второй точки: ");
bz = Coords("Введите координату z второй точки: ");

double distance = Distance(ax, ay, az, bx, by, bz);
Console.WriteLine(distance);


static int Coords(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    return result;
}
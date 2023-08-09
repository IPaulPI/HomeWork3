
// Task 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве. 
/*
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double deltaZ = z2 - z1;
    double hypQuad = (deltaX*deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ);
    return Math.Sqrt(hypQuad);
}

Console.WriteLine("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ($"Расстояние между точками равно {Distance(x1, x2, y1, y2, z1, z2)}");
*/
// Task 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void WriteQuad(int number)
{
    int current = 1;
    while(current <= number)
    {
        Console.WriteLine($"{current} - {current * current * current}");
        current++;
    }
}
Console.Write("Input the number: ");
int num = Convert.ToInt32(Console.ReadLine());

WriteQuad(num);
*/
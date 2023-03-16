// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

try
{
Console.WriteLine("Введите координаты точки А в трехмерном пространстве (x, y, z)");
Console.Write("x = ");
double x1 = Convert.ToSingle(Console.ReadLine());
Console.Write("y = ");
double y1 = Convert.ToSingle(Console.ReadLine());
Console.Write("z = ");
double z1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите координаты точки B в трехмерном пространстве (x, y, z)");
Console.Write("x = ");
double x2 = Convert.ToSingle(Console.ReadLine());
Console.Write("y = ");
double y2 = Convert.ToSingle(Console.ReadLine());
Console.Write("z = ");
double z2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Растояние между точками равно " + Distance(x1,x2,y1,y2,z1,z2));
}
catch
{
    Console.WriteLine("Введено недопустимое значение");
}


double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result1 = (x2 - x1)*(x2 -x1);
    double result2 = (y2 - y1)*(y2 -y1);
    double result3 = (z2 - z1)*(z2 -z1);
    double result = Math.Sqrt(result1+result2+result3);
    return result;
}
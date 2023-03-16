// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

try
{
    Console.WriteLine("Введите координаты точки А в трехмерном пространстве (x, y, z)");
    Console.Write("x = ");
    int x1 = System.Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y1 = System.Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    int z1 = System.Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B в трехмерном пространстве (x, y, z)");
    Console.Write("x = ");
    int x2 = System.Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int y2 = System.Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    int z2 = System.Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Растояние между точками равно " + Distance(x1, y1, z1, x2, y2, z2));
}
catch
{
    Console.WriteLine("Введено недопустимое значение");
}


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result1 = Math.Pow(x2 - x1, 2);
    double result2 = Math.Pow(y2 - y1, 2);
    double result3 = Math.Pow(z2 - z1, 2);
    double result = Math.Sqrt(result1 + result2 + result3);
    return result;
}
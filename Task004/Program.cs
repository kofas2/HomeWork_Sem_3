// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.


Console.WriteLine("Введите число, обозначающее количество измерений пространстваж: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] a = new double[num];
double[] b = new double[num];
DistancePoint(a, b);



void DistancePoint(double[]a, double[]b)
{
for (int j = 0; j < num; j++)
{
    Console.Write($"Введите координаты точки a {j + 1}:\t ");
    a[j] = Convert.ToInt32(Console.ReadLine());
}
for (int g = 0; g < num; g++)
{
    Console.Write($"Введите координаты точки b {g + 1}:\t ");
    b[g] = Convert.ToInt32(Console.ReadLine());
}
double x = 0;
double s = 0;
for (int i = 0; i < num; i++)
{
    s = b[i] - a[i];
    x += s * s;
    
}
double result = Math.Sqrt(x);
Console.WriteLine(result);
}


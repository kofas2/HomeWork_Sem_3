// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
try
{
Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов числа {num}: ");
CubeTable(num);
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}

void CubeTable(double num)
{
for (double i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 3)+", ");
}
}
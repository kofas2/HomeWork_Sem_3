// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.

try
{
Console.WriteLine("Введите целое число любой разрядности: ");
int num = Convert.ToInt32(Console.ReadLine());
int remind = 0;
int sum = 0;
int temp = num;
CheckPaly(num, remind, sum, temp);
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}

static void CheckPaly(int num, int remind, int sum, int temp)
{
    if (num > 10)
    {
        while (num > 0)
        {
            remind = num % 10;
            sum = (sum * 10) + remind;
            num = num / 10;
        }
        if (temp == sum)
        {
            Console.WriteLine($"{temp} - является палиндромом");
        }
        else
        {
            Console.WriteLine($"{temp} - не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine($"{num} - не является палиндромом");
    }
}
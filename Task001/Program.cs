// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int remind =0;
int sum = 0;
int temp = num;
CheckPaly(num, remind, sum, temp);




static void CheckPaly(int num, int remind, int sum, int temp)
{
    if (num > 9999 && num < 100000)
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
        Console.WriteLine($"Число {num} - не пятизначное");
    }
}



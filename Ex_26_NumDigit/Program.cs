// Задача 26: 
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumDigit (int num)
{
    int count = 0;
    if (num == 0) count = 1;
    else
    {
        while (num > 0)
        {
            num = num / 10;
            count += 1;
        }
    }
    return count;
}

int count = NumDigit(num);
Console.WriteLine($"В этом числе {count} цифр");
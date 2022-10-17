// Задача 28: 
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int NumMult (int num)
{
    int mult = 1;
    if (num == 0) mult = 0;
    else
    {
        for (int i = 1; i<= num; i++)
        {
            mult = mult * i;
        }
    }
    return mult;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int multiplication = NumMult (num);
Console.WriteLine($"Произведение чисел от 1 до {num} равно {multiplication}");
// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// 1,0,1,1,0,1,0,0

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] rand = new int[len];

rand = FillArray(len, rand);
PrintArray(len, rand);

int[] FillArray(int n, int[] array)
{
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 2);
}
return array;
}

void PrintArray(int n, int[] array)
{
for (int i = 0; i < n; i++)
{
    if (i == n-1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}, ");
}
}
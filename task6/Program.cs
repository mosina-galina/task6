//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите длинну массива ");
int m = int.Parse(Console.ReadLine() ?? "");
int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число ");
    array[i] = int.Parse(Console.ReadLine() ?? "");
}
int p = 0;
for (int k = 0; k < m; k++)
{
     if (array[k]>0) p++;
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{array[j]} ");
}
Console.Write($" Количество чисел больше 0 = {p}");
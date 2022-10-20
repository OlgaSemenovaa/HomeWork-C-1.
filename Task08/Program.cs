// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine ("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1)
Console.WriteLine("Недопустимое число");
else
{
    int count = a%2;
    while (count <= a)
    {
        Console.Write($"{count} ");
        count++;
    }
}
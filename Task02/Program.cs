//  Напишите программу, 
// 1. которая на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

// Пример
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine ("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > b) max = a;
if (b > a) max = b;

Console.Write("max = ");
Console.WriteLine(max);
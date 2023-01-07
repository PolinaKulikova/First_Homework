// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int a =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b =  Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a) max = b;

Console.Write( "max = ");
Console.WriteLine(max);





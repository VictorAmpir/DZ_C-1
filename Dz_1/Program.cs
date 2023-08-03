// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Задача 2: нахождение большего числа из двух задаваемых");
Console.WriteLine("Введите число 1");
int number21=Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число 2");
int number22=Convert.ToInt32 (Console.ReadLine());

if(number21 > number22)
{
    Console.WriteLine(number21);
}
else
{
    Console.WriteLine(number22);
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 3: нахождение большего числа из трех задаваемых");
Console.WriteLine("Введите число 1");
int number41=Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число 2");
int number42=Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число 3");
int number43=Convert.ToInt32 (Console.ReadLine());

int max = number41;
if (number41 > max) max = number41;
if (number42 > max) max = number42;
if (number43 > max) max = number43;

Console.Write("Максимальное число = ");
Console.WriteLine(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача 6: Проверка числа на четность");
Console.WriteLine("Введите число");
int number60=Convert.ToInt32 (Console.ReadLine());

if (number60%2==0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8: Показать все четные числа от 1 до заданного числа");
Console.WriteLine("Введите число");
int number80=Convert.ToInt32 (Console.ReadLine());

int Number = 2;

if(number80 > 1)
{
    while(Number <= number80)
    {
        Console.Write(Number + " ");
        Number = Number + 2;
    }
}

// Готово
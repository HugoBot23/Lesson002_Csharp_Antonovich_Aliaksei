// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//Решение.

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number1 = int.Parse(Console.ReadLine());
int number2 = number1 / 10;
int number3 = number2 % 10;
Console.WriteLine($"Вторая цифра введенного числа {number3}");
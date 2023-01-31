// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Решение.

Console.Clear();
Console.WriteLine("Ввидите любое число");
string number = Console.ReadLine();
if (number.Length > 2)
{
  Console.WriteLine($"Третья цифра заданного числа {number[2]}");
}
else
{
  Console.WriteLine("В заданном числе нет третьей цифры");
}
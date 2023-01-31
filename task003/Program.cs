// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//Решение.

Console.Clear();
Console.WriteLine("Введите цифру обозначающую день недели");
int number = int.Parse(Console.ReadLine());
if (number == 6)
{
  Console.WriteLine($"{number} день в неделе является выходным");
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.WriteLine("Суббота");
}
if (number == 7)
{
  Console.WriteLine($"{number} день в неделе является выходным");
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("Воскресенье");
}
else if (number != 6 && number != 7)
{
  if (number == 1)
  {
    Console.WriteLine($"{number} день не является выходным");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Понедельник");
  }
  if (number == 2)
  {
    Console.WriteLine($"{number} день не является выходным");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Вторник");
  }
  if (number == 3)
  {
    Console.WriteLine($"{number} день не является выходным");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Среда");
  }
  if (number == 4)
  {
    Console.WriteLine($"{number} день не является выходным");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Четверг");
  }
  if (number == 5)
  {
    Console.WriteLine($"{number} день не является выходным");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Пятница");
  }
}
Console.ForegroundColor = ConsoleColor.White;
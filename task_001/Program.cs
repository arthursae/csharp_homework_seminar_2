// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите целое трёхзначное число: ");
string inputString = Console.ReadLine();
int inputNumber = int.Parse(inputString);

int secondNumber = inputNumber / 10 % 10;
char secondChar = inputString[1];

Console.WriteLine("Вторая цифра числа: " + secondNumber);
Console.WriteLine("Второй символ строки: " + secondChar);

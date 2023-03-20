//Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите 3-х значное число");
int number = int.Parse(Console.ReadLine());

int res = number % 10;

Console.WriteLine($"Последняя цифра = {res}");
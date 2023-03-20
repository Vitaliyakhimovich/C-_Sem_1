// Напишите программу, которая на вход принимает 2 числа 
// и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите первое целое число:");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine($"Число {numberA} является квадратом второго числа");
}
else
{
    Console.WriteLine($"Число {numberA} не является квадратом второго числа");
}
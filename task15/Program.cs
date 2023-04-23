// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == Math.Pow(numberB,2) || numberB == Math.Pow(numberA,2)) // Math.Pow(numberB,2) numberB * numberB
{
    Console.WriteLine($"Да");
}
else
{
    Console.WriteLine($"Нет");
}
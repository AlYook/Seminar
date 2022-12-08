//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
//int digitCount = (int)Math.Log10(num) + 1; самое простое решение
int count = 0;

for (; num > 0; count++)
 {
    num /= 10;
 }

Console.WriteLine(count);

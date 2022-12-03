// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// Например: 456 -> 46

int random = new Random().Next(100, 1000);
Console.WriteLine(random);

int num1 = random / 100;
int num2 = random % 100;
int num3 = num2 % 10;

Console.WriteLine($"{num1}{num3}");
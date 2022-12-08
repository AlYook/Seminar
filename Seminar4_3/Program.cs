//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.\

Console.WriteLine("Введите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {limit} равна {GetMult(limit)}");

int GetMult(int limit)
{
    int mult = 1;
    for (int i = 1; i <= limit; i++)
        mult *=i;
    return mult;
}
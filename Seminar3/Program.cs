// Напишите программу, которая на вход
// принимает два числа и проверяет, является ли первое
// число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет 


Console.WriteLine("Enter number1 ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number2 ");
int num2 = int.Parse(Console.ReadLine());
int sqr = num2 * num2;

if (sqr == num1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
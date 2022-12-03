// Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
// второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter number 1 ");
string enterNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(enterNum1);

Console.WriteLine("Enter number 2 ");
string enterNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(enterNum2);
Console.WriteLine($"{num2},{num1}");


if (num2 % num1 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно. Остаток {num2 % num1}");
}
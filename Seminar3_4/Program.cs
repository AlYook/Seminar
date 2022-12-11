// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.WriteLine ("Enter num : ");
int num = int.Parse(Console.ReadLine());

double temp = 1;
double pow = 0;
while (temp<=num)
{
    pow = Math.Pow(temp, 2);
    Console.Write(pow);
    Console.Write(",");
    temp++;
}
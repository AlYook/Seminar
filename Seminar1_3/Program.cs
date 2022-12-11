// Напишите программу, которая на вход
// принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Enter number : ");
string enterNum = Console.ReadLine();

int num = Convert.ToInt32(enterNum);
int temp = 0 - num; 

while(temp <= num)
{
    Console.Write(temp);
    Console.Write(", ");
    temp++;
}

//Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на само себя)
Console.WriteLine("Enter number1 : ");
string enterNum1 = Console.ReadLine();
Console.WriteLine("Enter number2 : ");
string enterNum2 = Console.ReadLine();

int num1 = Convert.ToInt32(enterNum1);
int num2 = Convert.ToInt32(enterNum2);
int sqr = num2 * num2;
if (num1 == sqr)
{
    Console.WriteLine("Yes");
 
}
else 
{
  Console.WriteLine("No"); 
}
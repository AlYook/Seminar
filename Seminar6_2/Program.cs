//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
// Console.Clear();

Console.Write("Введите количество строк массива: ");
var rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArrayMatrix(rows, columns,10,99);
PrintArray(array);

int[,] GetArrayMatrix(int rows, int columns, int minValue=0, int maxValue=100)
{
    int[,] result = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

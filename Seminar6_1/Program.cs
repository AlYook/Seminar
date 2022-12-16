// //Напишите программу, которая перевернёт одномерный массив 
// //(последний элемент будет на первом месте, а первый - на последнем и т.д.)


int[] array1 = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array1));

ReversArray1(array1);
Console.WriteLine(String.Join(" ", array1));

array1=ReversArray2(array1);
Console.WriteLine(String.Join(" ", array1));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray)       //9 8 34 5 67 2 1
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int tmp = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = tmp;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];

    }
    return result;
}

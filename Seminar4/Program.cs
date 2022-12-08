int[] arr = new int[5];

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
    Console.WriteLine(i - 1);
    arr[i - 1] = i * i * i;
    Console.WriteLine(arr[i - 1]);
    Console.WriteLine("-------");

}


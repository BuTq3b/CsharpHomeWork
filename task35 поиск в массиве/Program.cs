/*
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

Console.Clear();

int size = 123;

int[] usserArr = RandomArr(size);
PrintArray(usserArr);
System.Console.WriteLine($"Количество двухзначных цисел в массиве: {Count(usserArr)}");

int[] RandomArr(int lean)
{
    int[] newArrey = new int[lean];
    for (int i = 0; i < lean; i++)
    {
        newArrey[i] = new Random().Next(10, 1000);
    }
    return newArrey;

}

int Count(int[] arr)
{
    int countN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            countN++;
        }
    }
    return countN;
}

void PrintArray(int[] arr)
{
    foreach (int i in arr)
        System.Console.Write(i + " ");

    System.Console.WriteLine();
}

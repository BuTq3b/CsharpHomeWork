/*
53. Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

Console.Clear();

int[,] Arrey(int a, int b)
{
    int[,] arre = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arre[i, j] = new Random().Next(1, 10);
        }
    }
    return arre;
}

void PrintArrey(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write(ar[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] AreeyRows(int[,] arr)
{
    int chart = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        chart = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = chart;
    }
    return arr;
}

Console.Write("Задайте количество строк массива: ");
int str = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int stolb = int.Parse(Console.ReadLine());

int[,] arrey2m = Arrey(str, stolb);
PrintArrey(arrey2m);

System.Console.WriteLine("Заменим первую строку на последнюю");

PrintArrey(AreeyRows(arrey2m));
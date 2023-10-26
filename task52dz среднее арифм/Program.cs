/*
52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();

int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void AverageSum(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];

        }
        
        double result = 0;
        result = sum/arr.GetLength(0);
       
        Console.Write(Math.Round(result, 2) + "\t");
    }


}

int[,] user2DArray = Get2DArray(5, 7);
Print2DArray(user2DArray);
System.Console.WriteLine();
AverageSum(user2DArray);

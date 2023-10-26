/*
Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
*/
Console.Clear();
int sizeStrok, sizeStolb;
Console.WriteLine("Для создания таблицы, укажите количество строк: ");
sizeStrok = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов: ");
sizeStolb = int.Parse(Console.ReadLine());

double[,] arr = Arrey(sizeStrok, sizeStolb);
PrintArr(arr);

double[,] Arrey(int sizeI, int sizeJ)
{
    double[,] arr = new double[sizeI, sizeJ];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10) + new Random().NextDouble();
        }
    }
    return arr;
}

void PrintArr(double[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write(Math.Round(ar[i, j], 2) + "\t");
        }
    }
}
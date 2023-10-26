/*
50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого 
элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 и 2 -> 2
1 и 7 -> такого числа в массиве нет
*/
Console.Clear();
int sizeStrok, sizeStolb, serchX, serchY;
sizeStrok = 5;
sizeStolb = 4;
double[,] arr = Arrey(sizeStrok, sizeStolb);
PrintArr(arr);
System.Console.WriteLine();
Console.WriteLine("Для поиска элемента в таблице, укажите номер строки: ");
serchX = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите номер столбца: ");
serchY = int.Parse(Console.ReadLine());

Serch(arr, serchX - 1, serchY - 1);

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

void Serch(double[,] ar, int number1, int number2)
{

    if (number1 < ar.GetLength(0) && number2 < ar.GetLength(1))
    { System.Console.WriteLine("Элемент с такими координатами = " + Math.Round(ar[number1, number2], 2)); }
    else { System.Console.WriteLine("Такого элемента в таблице нет"); }

}
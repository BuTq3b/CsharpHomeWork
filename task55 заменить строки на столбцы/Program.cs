/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/
Console.Clear();
Console.Write("Задайте количество строк массива: ");
int str = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int stolb = int.Parse(Console.ReadLine());

int[,] arrey2m = Arrey(str, stolb);
PrintArrey(arrey2m);
System.Console.WriteLine();
int[,] newAr = Row(arrey2m);
PrintArrey(newAr);

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

int[,] Row(int[,] ar)
{
    int[,] result = new int[ar.GetLength(0), ar.GetLength(1)];
    if (ar.GetLength(0) != ar.GetLength(1)) System.Console.WriteLine("Количество строк и столбцов не совпадает"); 
        
    else
    {
        
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            for (int j = 0; j < ar.GetLength(1); j++)
            {
                result[i, j] = ar[j, i];
            }
        }
        
    }
    return result;
}
/*
Метод для вычисления суммы элементов в заданной строке row матрицы matrix. 
Метод принимает двумерный массив целых чисел matrix и номер строки row, 
а возвращает целое число - сумму элементов в данной строке.

Метод для определения строки с наименьшей суммой элементов. 
Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: 
номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.
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

int SSumOfRow(int[,] matrix, int rowSumm)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        summ = summ + matrix[rowSumm, i];
    }
    return summ;
}

int[] MinimumSumRow(int[,] matrix)
{
    
    int resultSum = SSumOfRow(matrix, 0);
    int resultRow = 0;
    int[] result = new int[2];
    result [0] = resultRow;
    result [1] = resultSum;

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int summ = SSumOfRow(matrix, i);

        if (summ < resultSum)
        {
            resultRow = i;
            resultSum = summ;
        }
    }
    return result;
}

Console.Write("Задайте количество строк массива: ");
int str = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int stolb = int.Parse(Console.ReadLine());

int[,] arrey = Arrey(str, stolb);
PrintArrey(arrey);
System.Console.WriteLine();

int[] minSumRow = MinimumSumRow(arrey);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

int rowToSum = minSumRow[0] + 1; 
int sum = SSumOfRow(arrey, rowToSum-1);
Console.WriteLine($"Сумма элементов в строке {rowToSum}: {sum}");

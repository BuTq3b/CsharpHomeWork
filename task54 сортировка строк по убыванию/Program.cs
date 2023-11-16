/* Метод для сортировки строк матрицы по убыванию. Он принимает на вход двумерный массив целых чисел matrix
 и сортирует каждую строку матрицы так, чтобы элементы в каждой строке шли по убыванию.
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

void SortRowsDescending(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols - 1; j++)
        {
            for (int k = 0; k < cols - 1 - j; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }

            }
        }
    }
}
Console.Write("Задайте количество строк массива: ");
int str = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int stolb = int.Parse(Console.ReadLine());

int[,] arrey = Arrey(str, stolb);
PrintArrey(arrey);
System.Console.WriteLine();
SortRowsDescending(arrey);
PrintArrey(arrey);

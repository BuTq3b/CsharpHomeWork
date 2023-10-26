/* 
48. Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
*/

int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = i+j;
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
            System.Console.Write(arr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] user2DArray = Get2DArray(5,7);
Print2DArray(user2DArray);
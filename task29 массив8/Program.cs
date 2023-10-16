/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] 
*/

Console.Clear();
Console.Write("Задайте длину массива: ");
int lean = int.Parse(Console.ReadLine());
Console.Write("Массив будет состоять из рандомных чисел, поэтому задайте начальный диапазон: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Конечный диапазон: ");
int max = int.Parse(Console.ReadLine());
int[] areay = NewArrayRandom(lean, min, max);
PrintArray(areay);


int[] NewArrayRandom(int leanArr, int minArr, int maxArr)
{
    int[] arre = new int[leanArr];
    for (int i = 0; i < leanArr; i++)
    {
        arre[i] = new Random().Next(minArr, maxArr);
    }
    return arre;
}

void PrintArray(int[] arr)
{
    foreach ( int i in arr)
        System.Console.Write(i + " ");
}
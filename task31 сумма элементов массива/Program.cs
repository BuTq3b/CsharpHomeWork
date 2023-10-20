/* 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

Console.Clear();
System.Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] usserArr = RandomArr(size);
PrintArray(usserArr);
Summ(usserArr);



int[] RandomArr(int lean)
{
    int[] newArrey = new int[lean];
    for (int i = 0; i < lean; i++)
    {
        newArrey[i] = new Random().Next(-9, 10);
    }
    return newArrey;

}


void Summ(int[] arrey)
{
    int sumPositive = 0;
    int sumNegative = 0;
    
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] > 0) sumPositive += arrey[i];
        else sumNegative += arrey[i];
    }
    System.Console.WriteLine($"Сумма положительных циифр = {sumPositive}");
    System.Console.WriteLine($"Сумма отрицательных циифр = {sumNegative}");
}

void PrintArray(int[] arr)
{
    foreach ( int i in arr)
        System.Console.Write(i + " ");

    System.Console.WriteLine();
}
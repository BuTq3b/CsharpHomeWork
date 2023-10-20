/* 
37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
Console.Clear();

System.Console.WriteLine("Укажите длину массива: ");
int size = int.Parse(Console.ReadLine());

int[] usserArr = RandomArr(size);
PrintArray(usserArr);
int[] newArr = Prodakt(usserArr);
PrintArray(newArr);

int[] RandomArr(int lean)
{
    int[] newArrey = new int[lean];
    for (int i = 0; i < lean; i++)
    {
        newArrey[i] = new Random().Next(1, 15);
    }
    return newArrey;

}

int[] Prodakt(int[] arr)
{
    int num = 0;
    int[] newArr = new int[arr.Length/2];
    for (int i = 0; i < arr.Length/2; i++)
    {
        num = arr[i] * arr[arr.Length - 1 - i];
        newArr[i] = num;
    }
    return newArr;
}

void PrintArray(int[] arr)
{
    foreach (int i in arr)
        System.Console.Write(i + " ");

    System.Console.WriteLine();
}

/* вариант для нечетной длины:

int[] MultArray(int[] array)
{
int[] result = new int[array.Length - array.Length / 2];
int temp = 0;
for (int i = 0; i < array.Length - array.Length / 2; i++)
{
if (i == array.Length - 1 - i)
{
result[i] = array[i];
continue;
}

temp = array[i] * array[array.Length - 1 - i];
result[i] = temp;
}
return result;
}
*/
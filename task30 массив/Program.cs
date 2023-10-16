/* 30. Напишите программу, которая выводит массив 
из 8 элементов, заполненный нулями и единицами в 
случайном порядке.
*/


int[] newArray = NewArrayFilledRandom();

PrintArray(newArray);

void PrintArray(int[] arr)
{
    foreach( int i in arr)
        System.Console.Write(i + "\t");
}

int[] NewArrayFilledRandom()
{
    int[] arr = new int[8];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

/* 
int[] GetRnd(int size)
{
    int[] array = new int[size];// = {1,0,1,0,0,0,1,1}
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
int[] userArray = GetRnd(8);
PrintArray(userArray);

*/
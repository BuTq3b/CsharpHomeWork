/*
[3, -10, 0, 2, -1, 9, 4, 5, 3]
pivot = 3
[-10, 0, 2, -1] + [3, 3] + [9, 4, 5]

[-10, 0, 2, -1]
pivot = -10
[] + [-10] + [0, 2, -1]

[0, 2, -1]
pivot = 0
[-1] + [0] + [2]


[9, 4, 5]
pivot = 9
[4, 5] + [9] + []


[4, 5]
pivot = 4
[] + [4] + [5]



[-10] + [-1] + [0] + [2] + [3, 3] + [4] + [5] + [9]
*/


int[] quickSort(int[] array, int leftIndex, int rightIndex){
    Console.WriteLine($"[{string.Join(", ", array)}]\nleftIndex={leftIndex}\nrightIndex={rightIndex}\n");
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    while (i <= j){
        while (array[i] < pivot){
            i++;
        }
        while (array[j] > pivot){
            j--;
        }
        if (i <= j){
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    if (leftIndex < j)
        quickSort(array, leftIndex, j);
    if (i < rightIndex)
        quickSort(array, i, rightIndex);

    return array;
}




Console.Clear();
int[] array = {3, -10, 0, 2, -1, 9, 4, 5, 3};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array, 0, array.Length - 1))}]");

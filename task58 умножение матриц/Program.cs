/*
Реализуйте класс MatrixOperations, который содержит следующие статические методы:

MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. 
Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply." 
В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.

MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA и matrixB. 
Метод возвращает новую матрицу, которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.

PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

Если аргументы не переданы, программа использует матрицы по умолчанию. 
Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и выполняет умножение матриц.
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
Console.Write("Задайте количество строк массива №1: ");
int str1 = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива №1: ");
int stolb1 = int.Parse(Console.ReadLine());

int[,] arreyOne = Arrey(str1, stolb1);
PrintArrey(arreyOne);
System.Console.WriteLine();

Console.Write("Задайте количество строк массива №2: ");
int str2 = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива №2: ");
int stolb2 = int.Parse(Console.ReadLine());

int[,] arreyToo = Arrey(str2, stolb2);
PrintArrey(arreyToo);
System.Console.WriteLine();
System.Console.WriteLine("Произведение массивов: ");

PrintArrey(MultiplyIfPossible(arreyOne,arreyToo));

int[,] MultiplyIfPossible(int[,] arreyFirst, int[,] arreySecond)    // проверка, можно ли перемножать (соответствует ли количество строк и столбцов у обоих массивов)
{
    int[,] result = new int[arreyFirst.GetLength(0), arreyFirst.GetLength(1)];

    if (arreyFirst.GetLength(0) != arreySecond.GetLength(0) || arreyFirst.GetLength(1) != arreySecond.GetLength(1))
    {
        System.Console.WriteLine("It is impossible to multiply.");
        
    }
    else 
    {
        result = MatrixMultiplication(arreyFirst,arreySecond);
    }
    return result;
}

int[,] MatrixMultiplication(int[,] arreyFirst, int[,] arreySecond) // Умножение
{
    int[,] result = new int[arreyFirst.GetLength(0), arreyFirst.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = arreyFirst[i, j] * arreySecond[i, j];
        }
    }
    return result;
}


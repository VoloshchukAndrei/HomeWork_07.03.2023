// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// cтроки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayOne = GetArray(rows, columns);
PrintArray(arrayOne);
Console.WriteLine();

int[] arrayTwo = SumRows(arrayOne);
PrintArrayTwo(arrayTwo);
Console.WriteLine();

SmallerSum(arrayTwo);


int[,] GetArray(int M, int N)
{
    int[,] result = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] N)
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            Console.Write($"{N[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumRows(int[,] N)
{
    int[] result = new int[N.GetLength(0)];
    for (int i = 0; i < N.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < N.GetLength(1); j++)
        {
            sum += N[i, j];
        }
        result[i] = sum;
    }
    return result;
}

void PrintArrayTwo(int[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
        Console.Write($"{N[i]} ");
    }
}

void SmallerSum(int[] N)
{
    int i = 0;
    int j = i + 1;
    for (; i < N.Length; i++)
    {
        if (N[i] < N[j])
        {
            j = i;
        }
    }
    int row = j + 1;
    Console.WriteLine($"Строка с наименьшей суммой элементов: №{row} ");
}
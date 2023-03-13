// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayOne = GetArray(rows, columns);
PrintArray(arrayOne);
Console.WriteLine();

int[,] arrayTwo = SortingArray(arrayOne);
PrintArray(arrayTwo);


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

int[,] SortingArray(int[,] N)
{
    for (int f = 0; f < N.GetLength(0); f++)
    {
        for (int i = 0; i < N.GetLength(1); i++)
        {
            for (int j = i + 1; j < N.GetLength(1); j++)
            {
                if (N[f, i] < N[f, j])
                {
                    int Q = N[f, i];
                    N[f, i] = N[f, j];
                    N[f, j] = Q;
                }
            }
        }
    }
    return N;
}


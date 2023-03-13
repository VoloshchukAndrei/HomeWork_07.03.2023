// **Задача 58:** Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] arrayOne = GetArray(rows, columns);
PrintArray(arrayOne);
Console.WriteLine();

int[,] arrayTwo = GetArray(rows, columns);
PrintArray(arrayTwo);
Console.WriteLine();

int[,] arrayThree = ArraySum(arrayOne, arrayTwo);
PrintArray(arrayThree);


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

int[,] ArraySum(int[,] N, int[,] M)
{
    int[,] result = new int[N.GetLength(0), N.GetLength(1)];
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            result[i, j] = N[i, j] * M[i, j];
        }
    }
    return result;
}
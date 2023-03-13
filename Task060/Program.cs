// **Задача 60** Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы 
//  каждого элемента.
// массив размером 2 x 2 x 2
// int[,,]
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


Console.Clear();

Console.Write("Введите количество двумерных массивов: ");
int twoArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,,] array = GetArray(twoArray, rows, columns);
PrintArray(array);
Console.WriteLine();

int[,,] GetArray(int M, int N, int K)
{
    int[,,] result = new int[M, N, K];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            int f = 0; 
            while (f < K)
            {
                int element = new Random().Next(1, 10);
                if(FindElement(result, element)) continue;
                result[i, j, f] = element;
                f++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] N)
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            for (int f = 0; f < N.GetLength(2); f++)
            {
                Console.Write($"{N[i, j, f]} ({i},{j},{f}) ");
            }
        }
        Console.WriteLine();
    }
}

bool FindElement(int[,,] N, int element)
{
    for (int i = 0; i < N.GetLength(0); i++)
    {
        for (int j = 0; j < N.GetLength(1); j++)
        {
            for (int f = 0; f < N.GetLength(2); f++)
            {
                if(N[i, j, f] == element)
                {
                    return true;
                }
            }
        }
    }
    return false;
}
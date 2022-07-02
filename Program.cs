// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.


int m = 3, n = 4;
double[,] array = new double[m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10) + new Random().NextDouble();
        array[i,j] = Math.Round(array[i,j],2);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
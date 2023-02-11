// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
 int[,]firstMatrix=new int[n,m];
 int[,]secondMatrix=new int[n,m];
 int[,] resultMatrix= new int[n,m];
int sum=0;

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {

       firstMatrix[i, j] = new Random().Next(1, 5);
       Console.Write($"  {firstMatrix[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine();


for (int i = 0; i < secondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {

       secondMatrix[i, j] = new Random().Next(1, 5);
       Console.Write($"  {secondMatrix[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i=0;i<resultMatrix.GetLength(0);i++)
{
    for (int j = 0; j < resultMatrix.GetLength(0); j++)
    {
        for (int k = 0; k < resultMatrix.GetLength(0); k++)
        {
            sum+=firstMatrix[i,k]*secondMatrix[k,j];
        }
       resultMatrix[i,j]=sum;
       sum=0;
       Console.Write($"  {resultMatrix[i,j]}");
    }
    Console.WriteLine();
}


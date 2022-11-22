// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();

int [,] firstArray = new int [3, 3];
int [,] secondArray = new int [3, 3];
int [,] resultArray = new int [3, 3];
GetArrayRandom(firstArray);
GetArrayRandom(secondArray);

PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();

Console.WriteLine("Результат:");
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        resultArray[i, j] = firstArray[i, j] * secondArray[i, j];
    }
}
PrintArray(resultArray);



void GetArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " || ");
        }
        Console.WriteLine();
    }
}
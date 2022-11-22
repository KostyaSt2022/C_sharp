// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int arraySize = 4;
int[,] array = new int[arraySize, arraySize];

int row = 0;
int column = 0;
int count = 1;
int maxRow = arraySize - 1;
int maxColumn = arraySize - 1;
int minRow = 0;
int minColumn = 0;

array[row, column] = count;
count++;
FillArray(array, row, column, minRow, maxRow, minColumn, maxColumn, count);

void FillArray(int[,] array, int row, int column, int minRow, int maxRow, int minColumn, int maxColumn, int count)
{
    while (column < maxColumn)
    {
        column++;
        array[row, column] = count;
        count++;
    }
    minRow++;

    while (row < maxRow)
    {
        row++;
        array[row, column] = count;
        count++;
    }
    maxColumn--;

    while (column > minColumn)
    {
        column--;
        array[row, column] = count;
        count++;
    }
    maxRow--;

    while (row > minRow)
    {
        row--;
        array[row, column] = count;
        count++;
    }
    minColumn++;
    
    if (array[row, column + 1] == 0) FillArray(array, row, column, minRow, maxRow, minColumn, maxColumn, count);
}

for (int i = 0; i < arraySize; i++)
{
    for (int j = 0; j < arraySize; j++)
    {
        Console.Write(array[i, j] + "\t|");
    }
    Console.WriteLine();
}

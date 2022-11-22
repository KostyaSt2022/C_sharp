// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();

int [,] numbers = new int [5, 3];
GetArrayRandom(numbers);
PrintArray(numbers);

int minSumRow = 0;
int sumRow = SumElementsInRow(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumRow = SumElementsInRow(numbers, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}

Console.WriteLine($"Строкa {minSumRow+1} с наименьшей суммой элементов = {sumRow}");


int SumElementsInRow(int[,] array, int i)
{
  int sumOfRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumOfRow += array[i,j];
  }
  return sumOfRow;
}


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
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int maxArrayValue = 100;
int minArrayValue = 10;
int arraySize = 2;
int[,,] array = new int[arraySize, arraySize, arraySize];

int[] spareArray = new int[arraySize * arraySize * arraySize];

int temp;

for (int i = 0; i < spareArray.Length; i++) 
{
    while (spareArray[i] == 0)
    {
        temp = new Random().Next(minArrayValue, maxArrayValue);
        if (Array.IndexOf(spareArray, temp, i) == -1)
        {
            spareArray[i] = temp;
        }
    }
}

int count = 0;
for (int arrayDepth1 = 0; arrayDepth1 < arraySize; arrayDepth1++)
{
    Console.Write(">");
    for (int arrayDepth2 = 0; arrayDepth2 < arraySize; arrayDepth2++)
    {
        Console.Write(">");
        for (int arrayDepth3 = 0; arrayDepth3 < arraySize; arrayDepth3++)
        {
            array[arrayDepth1, arrayDepth2, arrayDepth3] = spareArray[count];
            count++;
            Console.WriteLine($"\t{array[arrayDepth1, arrayDepth2, arrayDepth3]}\t({arrayDepth1},{arrayDepth2},{arrayDepth3})");
        }
    }
}

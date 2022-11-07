// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] number = new int[8];

for (int i = 0; i < number.Length; i++)
 {
    number [i] = new Random().Next(0, 101);
    Console.Write(ReturnMethod (i) + " ");
 }

int ReturnMethod (int a)
{
    return number[a];
}
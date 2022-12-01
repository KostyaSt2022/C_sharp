/* Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int m, n;
Console.Write("Введите начальное значение M: ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение N: ");
n = Convert.ToInt32(Console.ReadLine());

void PrintRange(int start, int end)
{
    if (end > start)
    {
        PrintRange(start, end - 1);
        Console.Write(", ");
    }
    Console.Write(end);
}

PrintRange(m, n);

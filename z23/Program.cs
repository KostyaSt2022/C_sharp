// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void cube (int number)
{
    for(int i=1; i<=number; i++)
    {
        Console.WriteLine($"Куб {i*i*i} числа {number}");
    }
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
cube(number);
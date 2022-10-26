// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void revers(int number)
{
    if (number.ToString().Length == 5)
    {
        if ( (number.ToString()[0] == number.ToString()[4]) && (number.ToString()[1] == number.ToString()[3]) )
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {number} НЕ палиндром");
        }
    }
    else
    {
    Console.WriteLine($"Число {number} не пятизначное");
    }
}

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
revers(number);
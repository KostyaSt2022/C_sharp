// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число:");
int numb = int.Parse(Console.ReadLine()!);

if (numb < 100 | numb > 999)
{
    Console.WriteLine($"Число {numb} не трехзначное!");
}

 numb = numb / 10 % 10;
 Console.WriteLine($"Вторая цифра введённого числа: {numb}");
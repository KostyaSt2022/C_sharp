// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите трехзначное число:");
int numb = int.Parse(Console.ReadLine()!);

if (numb%7==0 && numb%23==0)
{
    Console.WriteLine($"Число {numb} КРАТНО 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {numb} не кратно 7 и 23");
}
//  Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели:");
int numb = int.Parse(Console.ReadLine()!);
if (numb >= 1 && numb <= 7)
{
    if (numb == 6 | numb == 7)
    Console.WriteLine("Сегодня выходной");
    else 
    Console.WriteLine("Сегодня рабочий день");
}
else 
{
    Console.WriteLine("Такого дня недели не существует!");
}
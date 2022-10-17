// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.WriteLine("Введите число:");
int numb = int.Parse(Console.ReadLine()!);
string lenghtOfNumb = numb.ToString();

if (lenghtOfNumb.Length > 2)
{
    Console.WriteLine($"Третья цифра числа {numb}: {lenghtOfNumb[2]}");
}
else
{
    System.Console.WriteLine($"Третьей цифры в числе {numb} нет!");
}
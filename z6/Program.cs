//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine()!);

if (numb % 2 == 0)
{
    Console.WriteLine($"Число {numb} четное.");
}
else
{
    Console.WriteLine($"Число {numb} нечетное.");
}
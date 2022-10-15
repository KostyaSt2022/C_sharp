//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите диапозон");
int numb = int.Parse(Console.ReadLine()!);
int firstNumb = 1;

while(firstNumb <= numb)
    {
        if(firstNumb % 2 ==0)
        Console.WriteLine(firstNumb);
        firstNumb ++;
    }
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine("Введите 1-е число");
int numb1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2-е число");
int numb2 = int.Parse(Console.ReadLine()!);

int max = numb1;
if (numb2 > max) max = numb2;
Console.WriteLine($"Максимальное число: {max}");

// Альтернативный способ
/*if(numb1 > numb2)
{
    Console.WriteLine($"Число {numb1} больше чем {numb2}");
}
else
{
    Console.WriteLine($"Число {numb2} больше чем {numb1}");
} */
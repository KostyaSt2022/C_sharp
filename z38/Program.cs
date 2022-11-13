// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArrayRnd(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1,150));
    }
}

void PrintArray(double[] numbers) //Вывод массива
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

Console.WriteLine("Введите кол-во чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
FillArrayRnd(numbers);

Console.WriteLine("Массив заполнен числами:");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное = {max}, минимальное = {min}");
Console.WriteLine($"Разница между макс и мин значением = {max - min}");
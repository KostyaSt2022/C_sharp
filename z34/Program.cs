// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArrayRnd(int[] numbers) //Задаем рандомный массив от 100 до 999
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers) //Вывод массива
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

int EvenNumber (int[] numbers) //Проверка четности чисел массива
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.WriteLine("Введите кол-во чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
FillArrayRnd(numbers);

Console.WriteLine("Массив заполнен числами:");
PrintArray(numbers);

Console.WriteLine($"Всего {numbers.Length} чисел, {EvenNumber(numbers)} из них чётные");
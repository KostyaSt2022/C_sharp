// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArrayRnd(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-50,51);
    }
}

void PrintArray(int[] numbers) //Вывод массива
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

int SumOfOddPosition(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i+=2)
    {
        sum = sum + numbers[i];
    }
    return sum;
}

Console.WriteLine("Введите кол-во чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
FillArrayRnd(numbers);

Console.WriteLine("Массив заполнен числами:");
PrintArray(numbers);

Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов нечетных позиций = {SumOfOddPosition(numbers)}");
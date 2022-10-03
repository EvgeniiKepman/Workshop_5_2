// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int count = 4;
int[] array = new int[count]; 
int n = 0;

AddArray(array);
PrintArray(array);

void AddArray(int[] array)
{
    Random rand = new Random();
    for(int i = 0; i < count; i++)
    {
        array[i] = rand.Next(1,9);
        if(i % 2 > 0)
        n = n + array[i];
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");

        if(i == count - 1)

            Console.WriteLine($"], сумма чисел в массиве, стоящих на нечетных позициях - {n}");

        else Console.Write(", ");
    }
    Console.WriteLine();
}

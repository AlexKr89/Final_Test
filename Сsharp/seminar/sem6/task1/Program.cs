// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Console.WriteLine("Введите длину массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение");
int minvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение");
int maxvalue = int.Parse(Console.ReadLine()!);

int[] arr = FillArray(num, minvalue, maxvalue);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
ReverseArray(arr);
Console.WriteLine();
PrintArray(arr);


int[] FillArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] ReverseArray(int[] array)
{
        for (int i = 0; i < array.Length/2; i++)
        {
            int buff = array[array.Length - i - 1];
            array[array.Length - i - 1] = array[i];
            array[i] = buff;
        }
    return array;
}
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.WriteLine("Введите размер массива");
int arrayLength = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение в массиве");
int minValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение в массиве");
int maxValue = int.Parse(Console.ReadLine()!);

int[] array = CreateArray(arrayLength, 1, 10);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
ReverseArray(array);
PrintArray(array);




int[] ReverseArray(int[] array)
{
    // int[] newArray = new int[array.Length];
    // int i = 0;
    // int j = array.Length - 1;
    // while(i < array.Length)
    // {
    //     newArray[j] = array[i];
    //     i++;
    //     j--;
    // }

    for (int i = 0; i < array.Length / 2; i++)
    {
        int buff = array[array.Length - i - 1];
        array[array.Length - i - 1] = array[i];
        array[i] = buff;
    }
    return array;
}

double[] CreateDoubleArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        double number = new Random().NextDouble() * (maxValue - minValue) + minValue;
        array[i] = Math.Round(number, 2);
    }
    return array;
}

int[] CreateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
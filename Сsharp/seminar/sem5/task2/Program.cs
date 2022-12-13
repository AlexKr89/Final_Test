// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// Задача 32
Console.WriteLine("Введите размер массива");
int N =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите нижнюю границу диапазона заполнения");
int min =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю границу диапазона заполнения");
int max =int.Parse(Console.ReadLine()!);

int[] arr = GenerateArray(N, min, max);

PrintArray(arr);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * (-1);
}

PrintArray(arr);

int[] GenerateArray(int size, int minBorder, int maxBorder)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minBorder, maxBorder);
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

// Задача 33

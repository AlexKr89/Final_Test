// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int numberB = int.Parse(Console.ReadLine()!);

// int exponent = numberA;

// for (int i = 1; i < numberB; i++)
// {
//     exponent = exponent * numberA;
// }
// while (numberA == 0 && numberB == 0)
// {
//     Console.Write("Выражение не имеет смысла, так как не может быть определено");
//     return;
// }
// Console.WriteLine("A в степени B = " + exponent);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int sum = sumDigit(number);
// Console.WriteLine(sum);

// int sumDigit(int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         int num = n % 10;
//         n = n / 10;
//         sum = sum + num;
//     }
//     return sum;
// }

// Задача 29: Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.

// 5, 1, 19 -> [1, 2, 5, 7, 19]

// 3, 1, 33 -> [6, 1, 33]

// Console.Write("Введите размерность массива: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите минимальное значение: ");
// int min = int.Parse(Console.ReadLine()!);
// Console.Write("Введите максимальное значение: ");
// int max = int.Parse(Console.ReadLine()!);


// int[] array = new int[n];

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
// }
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(array[position] + " ");
//         position++;
//     }
// }
// FillArray(array);

// PrintArray(array);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temprorary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprorary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
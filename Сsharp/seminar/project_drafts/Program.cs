// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int sumberA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int sumberB = int.Parse(Console.ReadLine()!);

// int exponent = sumberA;

// for (int i = 1; i < sumberB; i++)
// {
//     exponent = exponent * sumberA;
// }
// while (sumberA == 0 && sumberB == 0)
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
// int sumber = int.Parse(Console.ReadLine()!);

// int sum = sumDigit(sumber);
// Console.WriteLine(sum);

// int sumDigit(int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         int sum = n % 10;
//         n = n / 10;
//         sum = sum + sum;
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
//     int calc = array.Length;
//     int position = 0;
//     while (position < calc)
//     {
//         Console.Write(array[position] + " ");
//         position++;
//     }
// }
// FillArray(array);

// PrintArray(array);

// int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int calc = array.Length;

//     for (int i = 0; i < calc; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//             {
//                 minPosition = j;
//             }
//         }
//         int temprorary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temprorary;
//     }
// }

// PrintArray(array);
// SelectionSort(array);

// PrintArray(array);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Размер массива вводим через консоль

// [345, 897, 568, 234] -> 2

// Console.Write("Введите размер массива: ");
// int numsize = int.Parse(Console.ReadLine()!);

// int[] newArray = GenerateArray(numsize);
// Console.WriteLine();

// PrintArray(newArray);

// int[] GenerateArray(int size)
// {
//     int[] arrayRnd = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arrayRnd[i] = new Random().Next(100, 1000);
//     }
//     return arrayRnd;
// }

// int sumOdd(int[] newArray)
// {
//     int calc = 0;
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         if (newArray[i] % 2 == 0)
//         {
//             calc++;
//         }
//     }
//     return calc;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.Write("Количество четных = " + sumOdd(newArray));



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Размер массива, минимальное значение и максимальное значение вводим через консоль

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.Write("Введите размер массива: ");
// int numsize = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите минимальное значение");
// int min = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите максимальное значение");
// int max = int.Parse(Console.ReadLine()!);

// int[] newArray = GenerateArray(numsize, min, max);
// Console.WriteLine();

// PrintArray(newArray);

// int[] GenerateArray(int size, int min, int max)
// {
//     int[] arrayRnd = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arrayRnd[i] = new Random().Next(min, max + 1);
//     }
//     return arrayRnd;
// }

// int sumOdd(int[] newArray)
// {
//     int summ = 0;
//     for (int i = 1; i < newArray.Length; i += 2)
//     {

//         summ += newArray[i];
//     }
//     return summ;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.Write("Сумма нечетных = " + sumOdd(newArray));
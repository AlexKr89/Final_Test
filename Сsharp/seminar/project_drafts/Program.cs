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



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()

// [3 7 22 2 78] -> 76

// Random rnd = new Random();

// Console.Write("Введите размер массива: ");
// int numsize = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите минимальное значение");
// double min = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите максимальное значение");
// double max = double.Parse(Console.ReadLine()!);

// double[] newArray = GenerateArray(numsize, min, max);
// Console.WriteLine();

// PrintArray(newArray);

// double[] GenerateArray(int size, double min, double max)
// {
//     double[] arrayRnd = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         arrayRnd[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
//     }
//     return arrayRnd;
// }

// double resultDiff(double[] newArray)
// {
//     double findMin = newArray[0];
//     double findMax = newArray[0];
//     for (int i = 1; i < newArray.Length; i++)
//     {
//         if (findMin > newArray[i]) findMin = newArray[i];
//         if (findMax < newArray[i]) findMax = newArray[i];
//     }
//     return Math.Round((findMax - findMin), 2);
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.Write("Разница между максимальным и минимальным элементов массива = " + resultDiff(newArray));

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");

// Console.WriteLine("Задайте количество чисел: ");
// int num = int.Parse(Console.ReadLine()!);
// int[] arr = new int[num];

// Console.WriteLine($" -> {CounterPosNumber(FillArray(arr))}");

// int[] FillArray(int[] array)
// {
//     for (int j = 0; j < num; j++)
//     {
//         Console.WriteLine($"Введите {j + 1} число");
//         arr[j] = int.Parse(Console.ReadLine()!);
//     }
//     return array;
// }

// int CounterPosNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine()!);

// double[,] myMatrix = Create2DArray(m, n, -10, 10);
// Print2DArray(myMatrix);


// double[,] Create2DArray(int m, int n, int min, int max)
// {
//     double[,] matrix = new double[m, n];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
//         }
//     }
//     return matrix;
// }

// void Print2DArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет

// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine()!);

// int[,] myMatrix = Create2DArray(m, n, 0, 10);
// Print2DArray(myMatrix);

// Console.WriteLine("Введите номер строки");
// int line = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите номер столбца");
// int col = int.Parse(Console.ReadLine()!);

// if (line > m || col > n) Console.WriteLine("такого числа в массиве нет");
// else Console.WriteLine(myMatrix[line - 1, col - 1]);

// int[,] Create2DArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine();

// int[,] myMatrix = Create2DArray(m, n, 1, 10);
// Print2DArray(myMatrix);
// Console.WriteLine();

// for (int j = 0; j < myMatrix.GetLength(1); j++)
// {
//     double sumCol = 0;
//     int i = 0;
//     while (i < myMatrix.GetLength(0))
//     {
//         sumCol += myMatrix[i, j];
//         i++;
//     }
//     double avgVal = sumCol / i;
//     Console.Write(Math.Round(avgVal, 1) + "; ");
// }

// int[,] Create2DArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine();
// int[,] myMatrix = Create2DArray(m, n, 1, 10);
// Print2DArray(myMatrix);
// Console.WriteLine();
// int[,] newMatrix = SortMatrix(myMatrix);
// Print2DArray(newMatrix);

// int[,] SortMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             for (int k = j + 1; k < matrix.GetLength(1); k++)
//             {
//                 if (matrix[i, k] > matrix[i, j])
//                 {
//                     int temp = matrix[i, j];
//                     matrix[i, j] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return matrix;
// }

// int[,] Create2DArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max);
//         }
//     }
//     return matrix;
// }

// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine()!);

// int[,] helixMatrix = HelixFillMatrix(m, n);
// PrintMatrix(helixMatrix);

// int[,] HelixFillMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     int minValue = 1;
//     int maxValue = m * n;
//     int i = 0;
//     int j = 0;
//     int point = 0;
//     while (minValue <= maxValue)
//     {
//         matrix[i, j] = minValue;
//         if (i == point && j < n - 1 - point) j++;
//         else if (j == n - 1 - point && i < m - 1 - point) i++;
//         else if (i == m - 1 - point && j > point) j--;
//         else if (j == point && i > point) i--;
//         if (i == point && j == point)
//         {
//             i++; j++; point++;  
//         }
//         minValue++;
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < 10) Console.Write("0" + matrix[i, j] + " ");
//             else Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(OutputNumbers(num));

string OutputNumbers(int n)
{
    if (n == 1)
    {
        return n.ToString();
    }
    else
    {
        return n.ToString() + ", " + OutputNumbers(n - 1);
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int numM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int numN = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(numM, numN));

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + SumNumbers(m, n - 1);
    }
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите n");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите m");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(Ack(n, m));

int Ack(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return Ack(n - 1, 1);
    else
        return Ack(n - 1, Ack(n, m - 1));
}
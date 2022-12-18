// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите количество чисел ряда Фибоначи");
// int n = int.Parse(Console.ReadLine()!);
// int p1 = 0;
// int p2 = 1;

// int[] arr = FillArray(p1, p2, n);
// Console.WriteLine();
// PrintArray(arr);

// int FillArray(int n, int p1 = 0, int p2 = 1)
// {
//     if (n <= 1) return p1;
//     int p;
//     for (int j = 2; j < n; j++)
//     {
//         p = p1;
//         p1 = p2;
//         p2 = p2 + p;
//     }
//     return p2;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
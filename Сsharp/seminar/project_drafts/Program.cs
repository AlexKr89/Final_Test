// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// Console.Write("Введите число A: ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int numberB = int.Parse(Console.ReadLine()!);

// while (numberA == 0 && numberB == 0)
// {
//     Console.Write("Выражение не имеет смысла, так как не может быть определено");
//     return;
// }
// Console.Write("A в степени B = " + (Math.Pow(numberA, numberB)));


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

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 8);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();


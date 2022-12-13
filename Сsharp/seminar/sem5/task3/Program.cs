﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
//
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.WriteLine("Введите размер массива");
int N =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите нижнюю границу диапазона заполнения");
int min =int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите верхнюю границу диапазона заполнения");
int max =int.Parse(Console.ReadLine()!);

int[] arr = GenerateArray(N, min, max);

PrintArray(arr);

int[] GenerateArray(int n, int min, int max);

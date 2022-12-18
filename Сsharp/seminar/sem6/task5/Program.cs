//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] arr = { 5, 4, 7, 2, 9, 20, 10, 112 };

int[] copy = new int[arr.Length];
Array.Copy(arr, copy, arr.Length);

ReverseArray(arr);
Console.WriteLine();
PrintArray(arr);
// Console.WriteLine(String.Join(", ", copy));        // 5, 4, 7, 2, 9
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
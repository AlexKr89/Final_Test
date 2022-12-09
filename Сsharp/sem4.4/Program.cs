// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}
FillArray(array);

PrintArray(array);


// int[] GenerateArray()
// {
//     int[] array = new int[8];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,2);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// string ArrayToString(int[] array)
// {
//     string str = "";
//     for (int i = 0; i < array.Length; i++)
//     {
//         str += array[i] + " ";
//     }
//     return str;
// }

// int[] firstArrya = GenerateArray();
// PrintArray(firstArrya);

// int[] secondArray = GenerateArray();
// Console.WriteLine(ArrayToString(secondArray));
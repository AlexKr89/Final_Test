Console.WriteLine("Укажите размер массива");
int num = int.Parse(Console.ReadLine()!);
string[] arr = UserFillArray(num);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
int count = CountStringsNewArray(arr);
if (count > 0)
{
    string[] arrNew = FillArrayNew(arr, count);
    PrintArray(arrNew);
}
else Console.WriteLine("Не нашлось подходящих элементов");



string[] UserFillArray(int number)
{
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите строку");
        array[i] = Console.ReadLine()!;
    }
    return array;

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountStringsNewArray(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) counter++;
    }
    return counter;
}

string[] FillArrayNew(string[] array, int counter)
{
    string[] arrayNew = new string[counter];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    return arrayNew;
}

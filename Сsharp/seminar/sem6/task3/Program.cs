
// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(TenToTwo(number));


int TenToTwo(int num)
{
    int newNumber = 0;
    int multiplier = 1;
    while (num != 0)
    {
        newNumber += (num % 2) * multiplier;
        multiplier *= 10;
        num /= 2;
    }
    return newNumber;
}
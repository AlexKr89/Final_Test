// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


int count = Counter(number);
Console.WriteLine(count);

int Counter(int a)
{
    int count = 1;
    while (a > 9)
    {
        a = a / 10;
        count++;
    }
    return count;
}


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


int production = Productioner(number);
Console.Write(production);

int Productioner(int a)
{
    int production = 1;
    for (int i=1; i<=a; i++)
    {
        production=production*i;
    }
    return production;
}
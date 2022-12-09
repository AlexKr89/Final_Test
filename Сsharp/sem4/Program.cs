// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
 
int sumFromFunction = CalculateSum(number);
Console.WriteLine(sumFromFunction);
 
 
 
//<returnType> <functionName>(<param>)
int CalculateSum(int lastNumber)
{
    int sum = 0;
    for (int i = 1; i <= lastNumber; i++)
    {
        sum += i; // sum = sum + i
    }
    return sum;
}
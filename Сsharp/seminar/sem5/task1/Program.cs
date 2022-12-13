// Сумма всех цифр в введенном числе

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(DigitSum(number));

int DigitSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10; // sum = sum + num %10
        num /= 10; //num = num/10
    }
    return sum;
}
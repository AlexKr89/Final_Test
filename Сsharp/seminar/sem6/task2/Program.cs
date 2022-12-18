
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите сторону А");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону B");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону C");
int c = int.Parse(Console.ReadLine()!);

if (IsTriangleExists(a,b,c))
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");
}

bool IsTriangleExists(int a, int b, int c)
{
    if (a + b <= c)
    {
        return false;
    }
    else if (b + c <= a)
    {
        return false;
    }
    else if (c + a <= b)
    {
        return false;
    }
    else
    {
        return true;
    }
}
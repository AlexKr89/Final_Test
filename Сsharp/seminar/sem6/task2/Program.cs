
// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите сторону А");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону B");
int numB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону C");
int numC = int.Parse(Console.ReadLine()!);

if (triangle(numA, numB, numC))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}

bool triangle(int a, int b, int c)
{

    return a + b > c && a + c > b && b + c > a;

}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
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
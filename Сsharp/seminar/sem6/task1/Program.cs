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
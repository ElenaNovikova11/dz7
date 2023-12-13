// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int AF(int n, int m)
{
    if (n == 0) 
    return (m+1);
    else if (m == 0) 
    return (AF(n-1, 1));
    else  
    return (AF(n-1, AF(n,m-1)));
}
 
Console.Clear();
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
int a = AF (n, m);
Console.Write(a);
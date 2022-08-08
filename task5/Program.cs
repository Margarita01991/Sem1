// Программа на вход принимает одно число N на выходе показывает все целые числа в промежутке от -N до N
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int L = -N;

while (L <= N)
{
    Console.WriteLine(L);
    L++;
}



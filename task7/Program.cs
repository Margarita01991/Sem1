// программа которая принимает на вход трехзначное число а на выходе показывает последнюю цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = number%10;
Console.WriteLine(N);
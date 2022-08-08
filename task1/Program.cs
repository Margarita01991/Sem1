//  Программа которая на вход принимает два числа и проверяет является ли первое число квадратом второго
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int squareB = numberB * numberB;

    if (numberA == squareB)
{
    Console.WriteLine ("Да");
}
    else
{    
    Console.WriteLine ("Нет");
}

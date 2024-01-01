// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

Console.WriteLine("Введите число для M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для N");
int N = Convert.ToInt32(Console.ReadLine());

void NumbersInRange(int M, int N)
{
    if (M > N)
    {
        return;
    }

    Console.Write(M + " ");
    NumbersInRange(M + 1, N);
}

Console.Write("Числа от M до N: ");
NumbersInRange(M, N);
Console.WriteLine();

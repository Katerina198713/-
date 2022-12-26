// int NatStepenb (int A, int B)
// {
//     int result = Convert.ToInt32(Math.Pow(A, B));
//     return result;
// }

// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int result = NatStepenb(num1, num2);
// Console.WriteLine($"При возведении числа {num1} в {num2}-ю степень получается число {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumCifr (int num)
{
    int summ = 0;
    for(int i = 0; num >0;i++)
    {
        summ = summ + num%10;
        num = num/10;
    }
    return summ;
}
Console.WriteLine("Введите целое число:");
int N = Convert.ToInt32(Console.ReadLine());
int result = SumCifr(N);
Console.WriteLine($"Сумма цифр в числе {N} равна {result}");

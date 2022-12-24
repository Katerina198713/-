int NatStepenb (int A, int B)
{
    int result = Convert.ToInt32(Math.Pow(A, B));
    return result;
}

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = NatStepenb(num1, num2);
Console.WriteLine($"При возведении числа {num1} в {num2}-ю степень получается число {result}");
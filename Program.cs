// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NaturalNumbers (int N)
// {
//     if (N > 0)
//         {
//             Console.Write(N + " ");
//             NaturalNumbers (N-1);
//         }
// }

// Console.WriteLine ("Введите натуральное число больше 1");
// int a = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers (a);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int result=0;
// void SummNatNumb (int M, int N)
// {
//     if (M < N+1)
//     {
//         result += M;
//         SummNatNumb (M+1, N);
//     }
// }

// Console.WriteLine ("Введите первое натуральное число диапазона (M)");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите второе натуральное число диапазона (N)");
// int b = Convert.ToInt32(Console.ReadLine());

// SummNatNumb (a, b);
// Console.WriteLine ($"Сумма натуральных элементов в промежутке от M до N равна {result}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

///Метод вычисления функции Аккермана:
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");


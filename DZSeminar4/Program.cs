// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

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

// int SumCifr (int num)
// {
//     int summ = 0;
//     for(int i = 0; num >0;i++)
//     {
//         summ = summ + num%10;
//         num = num/10;
//     }
//     return summ;
// }
// Console.WriteLine("Введите целое число:");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = SumCifr(N);
// Console.WriteLine($"Сумма цифр в числе {N} равна {result}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for(int i=0;i<size;i++)
//     {
//         myArray[i] = new Random().Next(minValue,maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateRandomArray(lenght,min,max));
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray (int size) // создает массив рандоиных положительных трехзначных чисел
// {
//     int[] myArray = new int[size];
//     int minValue = 100;
//     int maxValue = 999;
//     for(int i=0;i<size;i++)
//     {
//         myArray[i] = new Random().Next(minValue,maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array) // выводит на печать полученный массив
// {
//     Console.WriteLine("Полученный массив ->:");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// void CountChetnyh (int [] array) // Определение колиичества четных чисел
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array [i] % 2 == 0)
//         {
//             count= count + 1;
//         }
//     }
//     Console.WriteLine ($"В массиве {count} четных чисел");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());;
// // Console.WriteLine("Введите минимальное значение диапазона положительных трехзначных чисел:");
// // int min = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Введите максимальное значение диапазона положительных трехзначных чисел:");
// // int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(lenght);
// ShowArray (myArray);
// CountChetnyh (myArray);
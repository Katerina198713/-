// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// int [] PrintArray(int num)
// {
//     int lenght = 5;
//     int [] array = new int [lenght];
//     for (int i = lenght-1; i>-1; i=i-1)
//     {
//         array [i] = num % 10;
//         num=num/10;
//         lenght = lenght-1;
//     }
//     return array;
//    }

// void Polindrom(int [] array)
// {
//     int size = array.Length;
//     string result = "Число является полиндромом";
//     for(int i = 0; i < array.Length/2; i++)
//     {    
//         if(array[i] == array[size-1])
//         {
//             size = size - 1;
//         }
//         else
//         {
//             result = "Число не является полиндромом";
//             break;
//         }
//     }
//     Console.WriteLine(result);
// }

// Console.WriteLine("Введите пятизначное число");
// int a = Convert.ToInt32(Console.ReadLine());
// Polindrom(PrintArray(a));

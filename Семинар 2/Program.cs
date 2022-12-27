
//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int FindSum (int num)
// {
//     int sum = 0;
//     for(int current= 1; current<=num;current++)
//     {
//         sum += current;
//     }
//     return sum;
// }

// Console.WriteLine("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = FindSum(a);
// Console.WriteLine(result);
//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// int FindLenght (int number)
// {
//     int count = 0;
//     for(int i =0; number>0;i++)
//     {
//         number=number/10;
//         count = count + 1;
//     }
//     return count;
// }

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = FindLenght(num);
// Console.WriteLine($"длинна числа {result}");


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int factorial (int number)
// {
//     int fact = 1;
//     for(int i = 1; i<=number; i++)
//     {
//         fact = fact * i;
//     }
//     return fact;
// }

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// int fact = factorial(num);
// Console.WriteLine($"факториал числа {num} равен {fact}");

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

// // int[] newArray = CreateRandomArray(lenght,min,max);
// // ShowArray(newArray);

// ShowArray(CreateRandomArray(lenght,min,max));

// Задача. Дан текст. В тексте все пробелы нужно заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// string Zamena (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;

//     for (int i=0; i<length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";          
//     }
//     return result;
// }

// string NewText = Zamena(text, ' ', '-');
// Console.WriteLine(NewText);
// Console.WriteLine();
// string NewText2 = Zamena(NewText, 'к', 'К');
// Console.WriteLine(NewText2);
// Console.WriteLine();
// string NewText3 = Zamena(NewText2, 'В', 'в');
// Console.WriteLine(NewText3);

// Задача. Задан массив [2,6,1,4,8,7,3,5], нужно отсортировать элементы массива по-возрастанию - [1,2,3,4,5,6,7,8]

// int[] arr = {2, 6, 1, 4, 8, 7, 3, 5};

// void PrintArray (int [] array)
// {
//     int count = array.Length;

//     for(int i=0; i<count; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// void Sort(int [] array)
// {
//     for (int i=0; i<array.Length-1; i++)
//     {
//         int minPosition = i;
// // поиск минимального значения
//         for(int j=i+1; j<array.Length; j++)
//         {
//         if(array[j]<array[minPosition]) minPosition = j;
//         }

// // перемена местами
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// Console.WriteLine();
// Sort(arr);

// PrintArray(arr);

// Задача. Сздайте последовательность Фибоначи из N цифр, где первых 2 числа 0 и 1, а остальные числа формируются путем нахождения суммы двух предыдущих чисел.

// int[] CreateRandomArray(int n, int a, int b)
//   {
//       int[] myArray = new int[n];
//       myArray[0] = a;
//       myArray[1] = b;
//       for (int i = 2; i < n; i++)
//       {
//           myArray[i] = myArray[i-2] + myArray[i-1];
//       }
//       return myArray;
//  }

//   void ShowArray(int[] array)
//  {
//       Console.WriteLine("Полученный массив ->:");
//       for (int i = 0; i < array.Length; i++)
//       {
//           Console.Write(array[i] + " ");
//       }
//       Console.WriteLine();
//  }


//  Console.WriteLine("Введите размер массива:");
//  int lenght = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите первый элемент массива:");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите второй элемент массива :"); 
//  int b = Convert.ToInt32(Console.ReadLine());                                  

//  int[] newArray = CreateRandomArray(lenght,a,b);

//  ShowArray(newArray);


//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

// string Method4(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num%2 +result;
//         num = num / 2;
//     }
//     return result;
// }

// string res = Method4(45);
// Console.WriteLine(res);

// СЕМИНАР 5

//Задача  Напишите программу, которая выводит массив и считает сумму всех положительных и отрицательных элементов массива

// int[] CreateRandomArray (int size,int minValue, int maxValue) // создает массив
// {
//     int[] myArray = new int[size];
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


// void findMinMax(int [] array) // находит сумму отрицательных и положительных элементов массива
// {
//     int summPositive = 0;
//     int summNegative = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>0) summPositive += array[i]; //summPositive = summPositive+array[i];
//         else 
//         summNegative += array[i];
//     }
//     Console.WriteLine($"Сумма всех положительных элементов массива равна {summPositive}");
//     Console.WriteLine($"Сумма всех отрицательных элементов массива равна {summNegative}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(lenght,min,max);
// ShowArray (myArray);
// findMinMax (myArray);

// Задача. Напишите программу замены элементов массива. все отрицательные элементы замените соответствиующими положительными и наоборот.

// int[] CreateRandomArray (int size,int minValue, int maxValue) // создает массив
// {
//     int[] myArray = new int[size];
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

// void ZamenaPozNeg(int [] array) // замена отрицательных на соответствующие положительные элементы и наоборот
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array [i] = array[i] *-1;
//     }
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] myArray = CreateRandomArray(lenght,min,max);
// ShowArray (myArray);
// ZamenaPozNeg (myArray);
// ShowArray (myArray);
//
//
//СЕМИНАР 5

// Задача. Задайте массив и определите, есть ли в нем заданное число.

// void SearchNum (int [] array, int num)
// {
//     string result = "нет";
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array [i] == num) result = "да";            
//     }
//     Console.WriteLine ($"Число {num} входит в массив?: {result}");    
// }
// int [] newArray = {1,2,3,5,17,28,64,15,10,81,9,18,48,8,7,19,21,105,46,1,7,5};
// Console.WriteLine("Введите искомое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// SearchNum (newArray, a);

// Задача. Задайте массив из 123 случайных элементов и определить сколько чисел лежит в отрезке от 10 до 99

int[] CreateRandomArray (int size, int minValue, int maxValue) // создает массив рандоиных элементов
{
    int[] myArray = new int[size];
    for(int i=0;i<size;i++)
    {
        myArray[i] = new Random().Next(minValue,maxValue+1);
    }
    return myArray;
}

void ShowArray (int[] array) // выводит на печать полученный массив
{
    Console.WriteLine("Полученный массив ->:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void Count2Znachnyh (int [] array) // Определение колиичества двухзначных чисел
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array [i] > 9 && array [i] < 100)
        {
            count= count + 1;
        }
    }
    Console.WriteLine ($"В массиве {count} двухзначных элементов");
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(lenght, min, max);
ShowArray (myArray);
Count2Znachnyh (myArray);










// СЕМИНАР 

// Задайте двухмерный массив и создайте метод, который меняет местами 1 и последнюю строку массива (сделаем чтоб менялись любая строка с любой)














// ДВУМЕРНЫЕ МАССИВЫ

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         string[,] table = new string[2, 3];
//     }
// }

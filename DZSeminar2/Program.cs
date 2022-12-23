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

// void Palindrom(int [] array)
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
// Palindrom(PrintArray(a));

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


void Coordinats( double x, double y,double x1, double y1,double z, double z1)
{
   Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x-x1),2) + Math.Pow((y-y1),2) + Math.Pow((z-z1),2)),2));
}
Console.WriteLine("input x=");
double x=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y=");
double y=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input z=");
double z=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input x1=");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input y1=");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input z1=");
double z1=Convert.ToDouble(Console.ReadLine());
Coordinats(x,y,x1,y1,z,z1);
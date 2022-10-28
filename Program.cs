// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите натуральное число ");
// int y=Convert.ToInt32 ( Console.ReadLine());
// int i= x % y;
// if (i == 0) Console.WriteLine("Кратно");
//  else  Console.WriteLine("не кратно, остаток " + i);

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int x=new Random().Next(100, 999);

// int x1=x/100;

// int x2=x/10;

// int x3=x%10;
// Console.WriteLine(x);
// Console.Write(x1);
// Console.Write(x3);


// int x = new Random().Next(1, 1000000);

// int a1 = x % 10;
// int a3 = x / 100;

// int new_num = a3 * 10 + a1;

// Console.WriteLine($"Было {x}, стало {new_num}");

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// if (x % 7 == 0 && x % 23 ==0) Console.Write("Да");
// else Console.Write("Нет");

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите натуральное число ");
// int y=Convert.ToInt32 ( Console.ReadLine());
// if (x*x == y || y*y == x) Console.Write("Да");
// else Console.Write("Нет");

// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine("Введите натуральное число ");
// int y=Convert.ToInt32 ( Console.ReadLine());
// if (x*x == y ) Console.Write("Да");
// else if ( y*y == x) Console.Write("Да");
// else Console.Write("Нет");

// Напишите программу, которая выводит целое  число любой разрядности и удаляет вторую цифру слева этого числа.

int x = new Random().Next(1, 1000000);

int a1 = x % 10;
int a3 = x / 100;

int new_num = a3 * 10 + a1;

Console.WriteLine($"Было {x}, стало {new_num}");




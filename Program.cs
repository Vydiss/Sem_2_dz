// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// int num_1 = 7;
// int num_2 = 23;

// Console.Write("Введите число: ");
// int user_num = Convert.ToInt32(Console.ReadLine());

// if ((user_num % num_1 == 0) && (user_num % num_2 == 0))
// {
//     Console.WriteLine($"Число {user_num} кратно");
// }
// else
// {
//     Console.WriteLine($"Число {user_num} не кратно");
// }


// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Координата не должна равняться 0");
// }
// else
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("1");
//     }
//     if (x > 0 && y < 0)
//     {
//         Console.WriteLine("2");
//     }
//     if (x < 0 && y < 0)
//     {
//         Console.WriteLine("3");
//     }
//     if (x < 0 && y > 0)
//     {
//         Console.WriteLine("4");
//     }
// }


// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// Console.Write("Введите число от 10 до 99 включительно: ");
// int user_num = Convert.ToInt32(Console.ReadLine());

// if (user_num < 10 || user_num > 99)
// {
//     Console.WriteLine("Вы ввели неправильное число");
// }
// else
// {
//     int max = user_num % 10;
//     int num = user_num / 10;
//     if (max < num)
//     {
//         max = num;
//     }
//     Console.WriteLine($"{max}");
// }


// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 10;
// if (N < i)
// {
//     Console.Write($"{N}");
// }
// else
// {
//     while (N / i != 0)
//     {
//         i *= 10;
//     }
//     i /= 10;
//     int result = 0;
//     while (i > 0)
//     {
//         result = N / i;
//         N = N - (result * i);
//         if (i == 1)
//         {
//             Console.Write($"{result}");
//         }
//         else
//         {
//             Console.Write($"{result}, ");
//         }
//         i /= 10;
//     }
// }
// Console.WriteLine();
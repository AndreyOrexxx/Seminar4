// Задача 25
// Напишите метод, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В:");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("А в степени В равно:" + Math.Pow(A, B));
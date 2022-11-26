// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите числа");

Console.WriteLine("Значение А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Значение B");
int b = Convert.ToInt32(Console.ReadLine());

double result = Convert.ToInt32(Math.Pow(a, b));

Console.WriteLine("Число А в степени В равняется " + result);
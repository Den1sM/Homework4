//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.WriteLine("Ведите число");
int i = Convert.ToInt32(Console.ReadLine());
int Sum = 0;

while (i > 0)
{
int Num = i % 10;
i = i / 10;
Sum = Sum + Num;
}
Console.WriteLine("Сумма цифр данного числа равняется " + Sum);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] myArray = new int [8];

Console.WriteLine("Введите элементы массива"); 

for (int i = 0; i < 8; i++)
{
    myArray[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("");
}

Console.WriteLine("[" +String.Join(",",myArray)+"]"); 

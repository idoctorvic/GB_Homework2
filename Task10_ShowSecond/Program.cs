// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.Write("Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num/10%10);

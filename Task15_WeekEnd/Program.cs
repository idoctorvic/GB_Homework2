// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter a number between 1 and 7: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum == 6 || dayNum == 7)
{
    Console.WriteLine("It's a weekend! You can relax!");
}
else Console.WriteLine("Today is a working day!");

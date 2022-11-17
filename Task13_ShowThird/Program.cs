// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// version 1
// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int numLength = 0;
// int thirdDigitnum = num;
// while(num > 0)
// {
//     numLength++;
//     num = num / 10;
// }
// if(numLength < 3)
// {
//     Console.WriteLine("There is no third digit");
// }
// else
// {
//     int thirdDigit = thirdDigitnum / 100 % 10;
//     Console.WriteLine(thirdDigit);
// }

// version 2
Console.Write("Enter a number: ");
string numString = Console.ReadLine();
int numLength = numString.Length;
int numDigit = Convert.ToInt32(numString);

if(numLength < 3)
{
    Console.WriteLine("There is no third digit");
}
else
{
    int thirdDigit = numDigit / 100 % 10;
    Console.WriteLine(thirdDigit);
}
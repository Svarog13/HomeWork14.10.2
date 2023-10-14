using System;

Console.WriteLine("Enter the digit: ");
int digit = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(digit * i);
}

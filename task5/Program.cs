﻿Console.WriteLine("Insert number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert number b");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b || b == a * a)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
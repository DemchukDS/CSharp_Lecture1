﻿int max = obj1;

Console.WriteLine("Enter 5 object numbers: ");
Console.Write("The first - ");
int obj1 = Convert.ToInt32(Console.ReadLine());
Console.Write("The second - ");
int obj2 = Convert.ToInt32(Console.ReadLine());
Console.Write("The third - ");
int obj3 = Convert.ToInt32(Console.ReadLine());
Console.Write("The fourth - ");
int obj4 = Convert.ToInt32(Console.ReadLine());
Console.Write("The fifth - ");
int obj5 = Convert.ToInt32(Console.ReadLine());

if (obj1 > max) max = obj1;
if (obj2 > max) max = obj2;
if (obj3 > max) max = obj3;
if (obj4 > max) max = obj4;
if (obj5 > max) max = obj5;